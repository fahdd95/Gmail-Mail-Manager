using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


//This class content all gmail APIS orders


namespace GmailMailManager
{
    class Program
    {

        //Task Manager :-)
       
        static CancellationTokenSource TrashCancelManager = new CancellationTokenSource();
      

        //Permisions Requested and Aquired by the application
        static string[] Scopes = { GmailService.Scope.GmailModify};

        //The application works using OAuth.
        //While creating you project at https://console.developers.google.com/apis/credentials/consent make sure this application name matches the Application name
        //as shown in this image http://imgur.com/a/XODky
        //static string ApplicationName = "fahd95";
        public static async void MoveAllMessagesToTrash(string ApplicationName, string GmailUserId)
        {
            //Cancel Task
            try
            {
                await Task.Run(() =>
                {
   
                    // Call Method 

                    //Authentication
                    #region Authentication

                    UserCredential credential;

                    //client_secret.json is from https://console.developers.google.com/apis/dashboard
                    //it is recomended that you replace this file with your own application credentials
                    using (var stream = new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
                    {
                        string credPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                        credPath = Path.Combine(credPath, ".credentials/gmail-dotnet-quickstart.json");

                        credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                            GoogleClientSecrets.Load(stream).Secrets,
                            Scopes,
                            "User",
                            CancellationToken.None,
                            new FileDataStore(credPath, true)).Result;
                    }

                    #endregion



                    //Starting Service
                    var fahdservice = new GmailService(new BaseClientService.Initializer()
                    {
                        HttpClientInitializer = credential,
                        ApplicationName = ApplicationName,
                    });




                    //Infinite Loop 
                    for (; ; )
                    {
                        //Loop Breaker :-p

                        if (TrashCancelManager.IsCancellationRequested)
                            TrashCancelManager.Token.ThrowIfCancellationRequested();

                        //Create a request for a list of (messages / emails)
                        UsersResource.MessagesResource.ListRequest allmessageslistrequest = fahdservice.Users.Messages.List("me");


                        //Setting up the request
                        allmessageslistrequest.MaxResults = 1000;

                        //Executing and getting the response
                        var allmessages = allmessageslistrequest.Execute().Messages;

                        //Check if response isn't a null
                        //if it is it means the mailbox is empty
                        if (allmessages == null)
                        {
                            Console.WriteLine("All messages has been deleted");
                            break;
                        }
                        Console.WriteLine(allmessages.Count);



                        //Add all the message Ids to the deletion request
                        foreach (Message message in allmessages)
                        {
                            Console.WriteLine("Working With message " + message.Id);
                            Console.WriteLine("Creating Trash Request");
                            UsersResource.MessagesResource.TrashRequest DeleteReq = fahdservice.Users.Messages.Trash(GmailUserId, message.Id);
                            try
                            {
                                // Breaker :-p

                                if (TrashCancelManager.IsCancellationRequested)
                                    TrashCancelManager.Token.ThrowIfCancellationRequested();

                                DeleteReq.Execute();
                                Console.WriteLine("Request has been executed for message " + message.Id + '\n');
                              
                            }
                            catch
                            {
                                Console.WriteLine("Sorry :-( Somthing Went Wrong");
                            }
                        }
                    }

                }, TrashCancelManager.Token);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                TrashCancelManager = new CancellationTokenSource();
            }


           
        }


        public static async void UntrashAndUnfspamAllMessages(string ApplicationName, string GmailUserId)
        {
            try
            {
                await Task.Run(() =>
                {

                    // Call Method 

                    #region Authentication

                    UserCredential credential;

            //client_secret.json is from https://console.developers.google.com/apis/dashboard
            //it is recomended that you replace this file with your own application credentials
            using (var stream = new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/gmail-dotnet-quickstart.json");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "User",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
            }

            #endregion



            //Starting Service
            var fahdservice = new GmailService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });

            //Infinite Loop
            for (; ; )
            {
                //Loop Breaker :-p
                if (TrashCancelManager.IsCancellationRequested)
                TrashCancelManager.Token.ThrowIfCancellationRequested();


                //Create a request for a list of (messages / emails)
                UsersResource.MessagesResource.ListRequest allmessageslistrequest = fahdservice.Users.Messages.List("me");


                //Setting up the request
                allmessageslistrequest.MaxResults = 1000;

                //Include messages from SPAM and TRASH in the results.
                allmessageslistrequest.IncludeSpamTrash = true;

                //Executing and getting the response
                var allmessages = allmessageslistrequest.Execute().Messages;

                //Check if response isn't a null
                //if it is it means the mailbox is empty
              
                if (allmessages == null)
                {
                    Console.WriteLine("All messages has been deleted");
                    break;
                }
                Console.WriteLine(allmessages.Count);



                //Add all the message Ids to the deletion request
                foreach (Message message in allmessages)
                {
                    //Loop Breaker :-p
                    if (TrashCancelManager.IsCancellationRequested)
                    TrashCancelManager.Token.ThrowIfCancellationRequested();
         
                    Console.WriteLine("Working With message " + message.Id);
                    Console.WriteLine("Creating Untrash Request");
                    UsersResource.MessagesResource.UntrashRequest UntrashReq = fahdservice.Users.Messages.Untrash(GmailUserId, message.Id);
                    try
                    {
                        UntrashReq.Execute();
                        Console.WriteLine("Request has been executed for message " + message.Id + '\n');
                    }
                    catch
                    {
                        Console.WriteLine("Sorry :-( Somthing Went Wrong");
                    }
                }
            }
                },TrashCancelManager.Token);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                TrashCancelManager = new CancellationTokenSource();
            }
        }

        public static async void CancelAllTasks()
        {
            TrashCancelManager.Cancel();
        }



    }

  

}




