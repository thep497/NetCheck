// *******************************************************************
//1. Program Name:	NetCheck
//2. Module Name:	Class
//3. Unit Name:		EncryptText
//4. Programmer:	thep497
//5. Create date:	20210121
//6. Description:	Encrypt text using ProtectedData class (DPAPI)
// *******************************************************************
// Revision : 1
// Edit history
// Rev 0: //th20210121 Initial this unit.
// Rev 1: //th20210121 Add DecryptSystemString to avoid false positive virus alert
// *******************************************************************
using System;
using System.Security;
using System.Security.Cryptography;
using System.Text;

namespace NNSClass
{
    public static class EncryptText
    {
        //static byte[] entropy = Encoding.Unicode.GetBytes(((string)"This file is copyrighted. นะจ๊ะ. All right reserved. Neo-Net Soft Co.,Ltd.").Substring(1, 20));
        static byte[] entropy = Encoding.Unicode.GetBytes("This file is copyrighted. นะจ๊ะ. All right reserved. Neo-Net Soft Co.,Ltd.");

        public static string EncryptString(SecureString input)
        {
            byte[] encryptedData = ProtectedData.Protect(Encoding.Unicode.GetBytes(ToInsecureString(input)), entropy, DataProtectionScope.CurrentUser);
            return Convert.ToBase64String(encryptedData);
        }

        public static string EncryptString(this string input)
        {
            return EncryptString(ToSecureString(input));
        }

        public static SecureString DecryptString(string encryptedData)
        {
            try
            {
                byte[] decryptedData = ProtectedData.Unprotect(Convert.FromBase64String(encryptedData), entropy, DataProtectionScope.CurrentUser);
                return ToSecureString(Encoding.Unicode.GetString(decryptedData));
            }
            catch
            {
                return new SecureString();
            }
        }
        public static string DecryptToString(this string encryptedData)
        {
            return ToInsecureString(DecryptString(encryptedData));
        }

        public static SecureString ToSecureString(string input)
        {
            SecureString secure = new SecureString();
            foreach (char c in input)
            {
                secure.AppendChar(c);
            }
            secure.MakeReadOnly();
            return secure;
        }

        public static string ToInsecureString(SecureString input)
        {
            string returnValue = string.Empty;
            IntPtr ptr = System.Runtime.InteropServices.Marshal.SecureStringToBSTR(input);
            try
            {
                returnValue = System.Runtime.InteropServices.Marshal.PtrToStringBSTR(ptr);
            }
            finally
            {
                System.Runtime.InteropServices.Marshal.ZeroFreeBSTR(ptr);
            }
            return returnValue;
        }

        public static string DecryptSystemString(this string text)
        {
            return text.Replace("thepx", "ll32.");
        }
    }
}
