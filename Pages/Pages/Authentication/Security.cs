using System;
using System.Collections.Generic;
using System.Linq;

using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace GoWMS.Server.Pages.Pages.Authentication
{
    /// <summary>
    /// Summary description for Security
    /// </summary>
    public class Security
    {
        /// <summary>
        /// สำหรับเข้ารหัส และถอดรหัส
        /// </summary>
        public Security()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        /// <summary>
        /// สร้าง Code สำหรับเปลี่ยนแปลงข้อมูลเพื่อความปลอดภัย
        /// </summary>
        /// <param name="EncryptString">ข้อความที่ต้องการเข้ารหัส</param>
        /// <param name="SecretKey">Key สำหรับเข้ารหัสและถอดรหัส</param>
        /// <returns>ข้อความที่เข้ารหัสแล้ว</returns>	
        public static string EncryptString(string EncryptString, string SecretKey)
        {
            MemoryStream msEncrypt = new MemoryStream();
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            string secretKey = (SecretKey.Length == 8) ? SecretKey : MD5(SecretKey);

            // Key ที่ต้องใช้งานกันทั้งสองฝ่าย ข้อมูลลับ
            DES.Key = ASCIIEncoding.ASCII.GetBytes(secretKey);
            DES.IV = ASCIIEncoding.ASCII.GetBytes(secretKey);

            // ใช้ CreateEncryptor ในการเข้ารหัส
            ICryptoTransform myEncryptor = DES.CreateEncryptor();

            // ตัวแปร array สำหรับรับข้อความที่ต้องการเข้ารหัส ต้องแปลงเป็น ASCII
            byte[] pwd = ASCIIEncoding.ASCII.GetBytes(EncryptString);

            // เข้ารหัสข้อมูล ข้อมูลที่เข้ารหัสเรียบร้อยแล้วจะเก็บไว้ที่ msEncrypt
            CryptoStream myCryptoStream = new CryptoStream(msEncrypt, myEncryptor, CryptoStreamMode.Write);
            myCryptoStream.Write(pwd, 0, pwd.Length);
            myCryptoStream.Close();

            // ส่งค่าที่ encrypt แล้วกลับไป
            return Convert.ToBase64String(msEncrypt.ToArray());
        }

        /// <summary>
        /// ถอดรหัส Code
        /// </summary>
        /// <param name="DecryptString">ข้อความที่ต้องการถอดรหัส</param>
        /// <param name="SecretKey">Key สำหรับเข้ารหัสและถอดรหัส</param>
        /// <returns>ข้อความที่ถอดรหัสแล้ว</returns>
        public static string DecryptString(string DecryptString, string SecretKey)
        {
            MemoryStream msDecrypt = new MemoryStream();
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            string secretKey = (SecretKey.Length == 8) ? SecretKey : MD5(SecretKey);

            // Key ที่ต้องใช้งานกันทั้งสองฝ่าย ข้อมูลลับ
            DES.Key = ASCIIEncoding.ASCII.GetBytes(secretKey);
            DES.IV = ASCIIEncoding.ASCII.GetBytes(secretKey);

            // ใช้ CreateDecryptor ในการเข้าถอดรหัส
            ICryptoTransform myDecryptor = DES.CreateDecryptor();

            // ตัวแปร array สำหรับรับข้อความที่ต้องการถอดรหัส ไม่ต้องแปลงเป็น ASCII
            byte[] pwd = Convert.FromBase64String(DecryptString);

            // เข้ารหัสข้อมูล ข้อมูลที่เข้ารหัสเรียบร้อยแล้วจะเก็บไว้ที่ msDecrypt
            CryptoStream cCryptoStream = new CryptoStream(msDecrypt, myDecryptor, CryptoStreamMode.Write);
            cCryptoStream.Write(pwd, 0, pwd.Length);
            cCryptoStream.Close();

            // ส่งค่าที่ decrypt แล้วกลับไป ต้องแปลงจาก ASCII ให้กลับเป็น string ก่อน
            return ASCIIEncoding.ASCII.GetString(msDecrypt.ToArray());
        }

        /// <summary>
        /// เข้ารหัสเอกสาร โดยส่งออกมาเป็น Binary Stream
        /// </summary>
        /// <param name="InputFilePath">ชื่อเอกสารที่ต้องการเข้ารหัส</param>
        /// <param name="SecretKey">Key สำหรับเข้ารหัสและถอดรหัส</param>
        /// <returns>Binary Stream ที่เข้ารหัสแล้ว</returns>
        public static byte[] EncryptStream(string InputFilePath, string SecretKey)
        {
            // read an file to new byte array
            byte[] byteArray = File.ReadAllBytes(InputFilePath);
            // write data to the new stream
            MemoryStream memoryStream = new MemoryStream(byteArray);

            return EncryptStream(memoryStream, SecretKey);
        }

        /// <summary>
        /// เข้ารหัสเอกสาร โดยส่งออกมาเป็น Binary Stream
        /// </summary>
        /// <param name="BinaryStream">Stream ที่ต้องการเข้ารหัส</param>
        /// <param name="StreamLength">ขนาดของ Stream</param>
        /// <param name="SecretKey">Key สำหรับเข้ารหัสและถอดรหัส</param>
        /// <returns>Binary Stream ที่เข้ารหัสแล้ว</returns>
        public static byte[] EncryptStream(Stream BinaryStream, string SecretKey)
        {
            BinaryReader BinaryRead = new BinaryReader(BinaryStream);
            byte[] binaryData = BinaryRead.ReadBytes(Convert.ToInt32(BinaryStream.Length));

            string secretKey = (SecretKey.Length == 8) ? SecretKey : MD5(SecretKey);

            //A 64 bit key and IV is required for this provider.
            //Set secret key For DES algorithm.
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            DES.Key = ASCIIEncoding.ASCII.GetBytes(secretKey);
            DES.IV = ASCIIEncoding.ASCII.GetBytes(secretKey);

            //Create a DES decryptor from the DES instance.
            ICryptoTransform desencrypt = DES.CreateEncryptor();

            //Create crypto stream set to read and do a DES decryption transform on incoming bytes.
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptostream = new CryptoStream(memoryStream, desencrypt, CryptoStreamMode.Write);

            cryptostream.Write(binaryData, 0, binaryData.Length);
            cryptostream.FlushFinalBlock();
            cryptostream.Close();

            return memoryStream.ToArray();
        }

        /// <summary>
        /// เข้ารหัสเอกสาร
        /// </summary>
        /// <param name="InputFilePath">ชื่อเอกสารที่ต้องการเข้ารหัส</param>
        /// <param name="OutputFilePath">ชื่อเอกสารที่เข้ารหัสแล้ว</param>
        /// <param name="SecretKey">Key สำหรับเข้ารหัสและถอดรหัส</param>
        public static void EncryptFile(string InputFilePath, string OutputFilePath, string SecretKey)
        {
            //Create a encrypted file.
            FileStream fsEncrypted = new FileStream(OutputFilePath, FileMode.Create, FileAccess.Write);

            //Print the contents of the Encrypted file.
            byte[] byteArray = EncryptStream(InputFilePath, SecretKey);
            fsEncrypted.Write(byteArray, 0, byteArray.Length);
            fsEncrypted.Close();
        }

        /// <summary>
        /// เข้ารหัสเอกสาร
        /// </summary>
        /// <param name="BinaryStream">Stream ที่ต้องการเข้ารหัส</param>
        /// <param name="StreamLength">ขนาดของ Stream</param>
        /// <param name="OutputFilePath">ชื่อเอกสารที่เข้ารหัสแล้ว</param>
        /// <param name="SecretKey">Key สำหรับเข้ารหัสและถอดรหัส</param>
        public static void EncryptFile(Stream BinaryStream, string OutputFilePath, string SecretKey)
        {
            //Create a encrypted file.
            FileStream fsEncrypted = new FileStream(OutputFilePath, FileMode.Create, FileAccess.Write);

            //Print the contents of the Encrypted file.
            byte[] byteArray = EncryptStream(BinaryStream, SecretKey);
            fsEncrypted.Write(byteArray, 0, byteArray.Length);
            fsEncrypted.Close();
        }

        /// <summary>
        /// ถอดรหัสเอกสาร โดยส่งออกมาเป็น Binary Stream
        /// </summary>
        /// <param name="InputFilePath">ชื่อเอกสารที่ต้องการถอดรหัส</param>
        /// <param name="SecretKey">Key สำหรับเข้ารหัสและถอดรหัส</param>
        /// <returns>Binary Stream ที่ถอดรหัสแล้ว</returns>
        public static byte[] DecryptStream(string InputFilePath, string SecretKey)
        {
            // read an file to new byte array
            byte[] byteArray = File.ReadAllBytes(InputFilePath);
            // write data to the new stream
            MemoryStream memoryStream = new MemoryStream(byteArray);

            return DecryptStream(memoryStream, SecretKey);
        }

        /// <summary>
        /// ถอดรหัสเอกสาร โดยส่งออกมาเป็น Binary Stream
        /// </summary>
        /// <param name="BinaryStream">Stream ที่ต้องการถอดรหัส</param>
        /// <param name="StreamLength">ขนาดของ Stream</param>
        /// <param name="SecretKey">Key สำหรับเข้ารหัสและถอดรหัส</param>
        /// <returns>Binary Stream ที่ถอดรหัสแล้ว</returns>
        public static byte[] DecryptStream(Stream BinaryStream, string SecretKey)
        {
            BinaryReader BinaryRead = new BinaryReader(BinaryStream);
            byte[] binaryData = BinaryRead.ReadBytes(Convert.ToInt32(BinaryStream.Length));

            string secretKey = (SecretKey.Length == 8) ? SecretKey : MD5(SecretKey);

            //A 64 bit key and IV is required for this provider.
            //Set secret key For DES algorithm.
            DESCryptoServiceProvider DES = new DESCryptoServiceProvider();
            DES.Key = ASCIIEncoding.ASCII.GetBytes(secretKey);
            DES.IV = ASCIIEncoding.ASCII.GetBytes(secretKey); //Set initialization vector.

            //Create a DES decryptor from the DES instance.
            ICryptoTransform desdecrypt = DES.CreateDecryptor();

            //Create crypto stream set to read and do a DES decryption transform on incoming bytes.
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptostreamDecr = new CryptoStream(memoryStream, desdecrypt, CryptoStreamMode.Write);

            cryptostreamDecr.Write(binaryData, 0, binaryData.Length);
            cryptostreamDecr.FlushFinalBlock();
            cryptostreamDecr.Close();

            return memoryStream.ToArray();
        }

        /// <summary>
        /// ถอดรหัสเอกสาร
        /// </summary>
        /// <param name="InputFilePath">ชื่อเอกสารที่ต้องการถอดรหัส</</param>
        /// <param name="OutputFilePath">ชื่อเอกสารที่ถอดรหัสแล้ว</param>
        /// <param name="SecretKey">Key สำหรับเข้ารหัสและถอดรหัส</param>
        public static void DecryptFile(string InputFilePath, string OutputFilePath, string SecretKey)
        {
            //Create a file stream to read the encrypted file back.
            FileStream fsDecrypted = new FileStream(OutputFilePath, FileMode.Create, FileAccess.Write);

            //Print the contents of the Decrypted file.
            byte[] byteArray = DecryptStream(InputFilePath, SecretKey);
            fsDecrypted.Write(byteArray, 0, byteArray.Length);
            fsDecrypted.Close();
        }

        /// <summary>
        /// ถอดรหัสเอกสาร
        /// </summary>
        /// <param name="BinaryStream">Stream ที่ต้องการถอดรหัส</param>
        /// <param name="StreamLength">ขนาดของ Stream</param>
        /// <param name="OutputFilePath">ชื่อเอกสารที่ถอดรหัสแล้ว</param>
        /// <param name="SecretKey">Key สำหรับเข้ารหัสและถอดรหัส</param>
        public static void DecryptFile(Stream BinaryStream, string OutputFilePath, string SecretKey)
        {
            //Create a file stream to read the encrypted file back.
            FileStream fsDecrypted = new FileStream(OutputFilePath, FileMode.Create, FileAccess.Write);

            //Print the contents of the Decrypted file.
            byte[] byteArray = DecryptStream(BinaryStream, SecretKey);
            fsDecrypted.Write(byteArray, 0, byteArray.Length);
            fsDecrypted.Close();
        }

        /// <summary>
        /// สร้าง 64 bits Key สำหรับเข้ารหัสและถอดรหัส
        /// </summary>
        /// <returns>64 bits Key สำหรับเข้ารหัสและถอดรหัส</returns>
        public static string GenerateKey()
        {
            // Create an instance of Symetric Algorithm. Key and IV is generated automatically.
            DESCryptoServiceProvider desCrypto = (DESCryptoServiceProvider)DESCryptoServiceProvider.Create();

            // Use the Automatically generated key for Encryption. 
            return ASCIIEncoding.ASCII.GetString(desCrypto.Key);
        }

        /// <summary>
        /// ลบข้อมูล Key ออกจากหนวยความจำ
        /// </summary>
        /// <param name="SecretKey">Key สำหรับเข้ารหัสและถอดรหัส</param>
        public static void RemoveKey(string SecretKey)
        {
            // For additional security Pin the key.
            GCHandle gch = GCHandle.Alloc(SecretKey, GCHandleType.Pinned);

            // Remove the Key from memory. 
            ZeroMemory(gch.AddrOfPinnedObject(), SecretKey.Length * 2);
            gch.Free();
        }

        /// <summary>
        /// สร้าง 64 bits Key สำหรับเข้ารหัสและถอดรหัส
        /// </summary>
        /// <param name="SecretKey">Key สำหรับเข้ารหัสและถอดรหัส</param>
        /// <returns>64 bits Key สำหรับเข้ารหัสและถอดรหัส</returns>
        private static string MD5(string SecretKey)
        {
            string strReturn = string.Empty;
            byte[] ByteSourceText = ASCIIEncoding.ASCII.GetBytes(SecretKey);

            MD5CryptoServiceProvider Md5Hash = new MD5CryptoServiceProvider();
            byte[] ByteHash = Md5Hash.ComputeHash(ByteSourceText);

            foreach (byte b in ByteHash)
                strReturn = strReturn + b.ToString("x2");

            return strReturn.Substring(0, 8);
        }

        //  Call this function to remove the key from memory after use for security
        [DllImport("KERNEL32.DLL", EntryPoint = "RtlZeroMemory")]
        private static extern bool ZeroMemory(IntPtr Destination, int Length);
    }

}
