﻿namespace MerOmInterface.Chat
{
    internal class ChatDemo
    {
        public static void Run()
        {
            var server = new ChatServer();

            var client1 = new ChatClient("Per", server);
            var client2 = new ChatClient("Pål", server);
            var client3 = new ChatClient("Espen", server);

            client1.Say("Hello");
            // Pål og Espen får beskjed "Per sier Hello"

            client2.Say("Hello");
            // Per og Espen får beskjed "Pål sier Hello"

            client3.Say("Hello");
            // Per og Pål får beskjed "Espen sier Hello"
        }
    }
}
