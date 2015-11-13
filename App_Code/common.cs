using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Net.Mail;

/// <summary>
/// Summary description for common
/// </summary>
/// 
namespace ntspl
{
    public  class common
    {
        public common()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        //public static bool SendMail(string to, string subject, string message, Attachment att)
        //{
        //    try
        //    {

        //        System.Net.Mail.MailMessage MyMailMessage = new System.Net.Mail.MailMessage("hr.communication@vedanta.co.in", to, subject, message);
        //        MyMailMessage.IsBodyHtml = true;
        //        MyMailMessage.Priority = System.Net.Mail.MailPriority.High;

        //        System.Net.NetworkCredential mailAuthentication = new
        //        System.Net.NetworkCredential("hr.communication@vedanta.co.in", "hr@vedanta");

        //        System.Net.Mail.SmtpClient mailClient = new System.Net.Mail.SmtpClient("10.101.111.50", 25);

        //        mailClient.EnableSsl = false;

        //        mailClient.UseDefaultCredentials = false;

        //        mailClient.Credentials = mailAuthentication;

        //        MyMailMessage.Attachments.Add(att);

        //        mailClient.Send(MyMailMessage);
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //    return true;


        //}
        //public static bool SendMail1(string to, string subject, string message)
        //{
        //    try
        //    {

        //        System.Net.Mail.MailMessage MyMailMessage = new System.Net.Mail.MailMessage("hr.communication@vedanta.co.in", to, subject, message);
        //        MyMailMessage.IsBodyHtml = true;
        //        MyMailMessage.Priority = System.Net.Mail.MailPriority.High;

        //        System.Net.NetworkCredential mailAuthentication = new
        //        System.Net.NetworkCredential("hr.communication@vedanta.co.in", "hr@vedanta");

        //        System.Net.Mail.SmtpClient mailClient = new System.Net.Mail.SmtpClient("10.101.111.50", 25);

        //        mailClient.EnableSsl = false;

        //        mailClient.UseDefaultCredentials = false;

        //        mailClient.Credentials = mailAuthentication;


        //        mailClient.Send(MyMailMessage);
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //    return true;


        //}
        //public static bool SendMail(string to, string subject, string message)
        //{
        //    try
        //    {

        //        System.Net.Mail.MailMessage MyMailMessage = new System.Net.Mail.MailMessage("support.it@vedanta.co.in", to, subject, message);
        //        MyMailMessage.IsBodyHtml = true;
        //        MyMailMessage.Priority = System.Net.Mail.MailPriority.High;

        //        System.Net.NetworkCredential mailAuthentication = new
        //        System.Net.NetworkCredential("support.it@vedanta.co.in", "vedanta1234");

        //        System.Net.Mail.SmtpClient mailClient = new System.Net.Mail.SmtpClient("10.101.141.191", 25);

        //        mailClient.EnableSsl = false;

        //        mailClient.UseDefaultCredentials = false;

        //        mailClient.Credentials = mailAuthentication;

        //        mailClient.Send(MyMailMessage);
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //    return true;


        //}

        //public static bool SendMailSSC(string to, string subject, string message)
        //{
        //    try
        //    {

        //        System.Net.Mail.MailMessage MyMailMessage = new System.Net.Mail.MailMessage("empadvance.vserv@vedanta.co.in", to, subject, message);
        //        MyMailMessage.IsBodyHtml = true;
        //        MyMailMessage.Priority = System.Net.Mail.MailPriority.High;

        //        System.Net.NetworkCredential mailAuthentication = new
        //        System.Net.NetworkCredential("employeeadvance", "abc@1234");

        //        System.Net.Mail.SmtpClient mailClient = new System.Net.Mail.SmtpClient("10.101.141.106", 25);

        //        mailClient.EnableSsl = false;

        //        mailClient.UseDefaultCredentials = false;

        //        mailClient.Credentials = mailAuthentication;

        //        mailClient.Send(MyMailMessage);
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //    return true;


        //}
        public static bool sendMail(string eidTo, string eidFrom, string msgsub, string msgbody)
        {
            try
            {
                System.Net.Mail.MailMessage MyMailMessage = new System.Net.Mail.MailMessage("support.it@vedanta.co.in", eidTo, msgsub, msgbody);
                MyMailMessage.IsBodyHtml = true;
                MyMailMessage.Priority = System.Net.Mail.MailPriority.High;
                System.Net.NetworkCredential mailAuthentication = new
                System.Net.NetworkCredential("support.it", "vedanta@1234");
                System.Net.Mail.SmtpClient mailClient = new System.Net.Mail.SmtpClient("10.101.141.191", 25);
                mailClient.EnableSsl = false;
                mailClient.UseDefaultCredentials = false;
                mailClient.Credentials = mailAuthentication;
                mailClient.Send(MyMailMessage);
            }
            catch (Exception) { return false; }
            return true;
        }
    }
    public  enum UserType
    {
        user,
        helpdesk
    }
    public enum ApproveStatus
    {
        Approved,
        Pending,
        Rejected
    }
    public enum SaveMode
    { 
    New,
        Edit
    }
    public class Security
    {

        private static string passPhrase = "Sas5kr@pk";        // can be any string

        private static string saltValue = "s@6tVLtPe";        // can be any string

        private static string hashAlgorithm = "SHA1";             // can be "MD5"

        private static int passwordIterations = 2;                  //can be any number

        private static string initVector = "@7A4c3D5y5c6k7T8"; // must be 16 bytes

        private static int keySize = 256;                // can be 192 or 128 or 256

        public static string Encrypt(string plainText)
        {
            byte[] initVectorBytes = Encoding.ASCII.GetBytes(initVector);
            byte[] saltValueBytes = Encoding.ASCII.GetBytes(saltValue);
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, saltValueBytes, hashAlgorithm, passwordIterations);
            byte[] keyBytes = password.GetBytes(keySize / 8);
            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;
            ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes);
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
            cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
            cryptoStream.FlushFinalBlock();
            byte[] cipherTextBytes = memoryStream.ToArray();
            memoryStream.Close();
            cryptoStream.Close();
            string cipherText = Convert.ToBase64String(cipherTextBytes);
            return cipherText;
        }

        public static string Decrypt(string cipherText)
        {
            byte[] initVectorBytes = Encoding.ASCII.GetBytes(initVector);
            byte[] saltValueBytes = Encoding.ASCII.GetBytes(saltValue);
            byte[] cipherTextBytes = Convert.FromBase64String(cipherText);
            PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, saltValueBytes, hashAlgorithm, passwordIterations);
            byte[] keyBytes = password.GetBytes(keySize / 8);
            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;
            ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes);
            MemoryStream memoryStream = new MemoryStream(cipherTextBytes);
            CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
            byte[] plainTextBytes = new byte[cipherTextBytes.Length];
            int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
            memoryStream.Close();
            cryptoStream.Close();
            string plainText = Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
            return plainText;
        }
    }

}
