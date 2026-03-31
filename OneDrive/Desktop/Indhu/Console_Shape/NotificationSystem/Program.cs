using System;

namespace NotificationSystem
{
    // Delegate 
    public delegate void Notify(string message);
    class Program
    {
        // 1: Send Email
        public static void SendEmail(string message)
        {
            Console.WriteLine("Email Sent: " + message);
        }

        // 2: Send SMS
        public static void SendSMS(string message)
        {
            Console.WriteLine("SMS Sent: " + message);
        }

        // 3: Send WhatsApp
        public static void SendWhatsApp(string message)
        {
            Console.WriteLine("WhatsApp Message Sent: " + message);
        }

        static void Main(string[] args)
        {
            // Create delegate instance
            Notify notify = null;

            // Add methods 
            notify += SendEmail;
            notify += SendSMS;
            notify += SendWhatsApp;

            Console.WriteLine("Sending Notification to ALL Channels ");
            notify("Hello User!");

            Console.WriteLine();

            // Remove one method
            notify -= SendSMS;

            Console.WriteLine("After Removing SMS Channel ");
            notify("Hello Again!");

        }
    }
}