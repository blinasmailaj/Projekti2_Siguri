using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace serverForm
{
    class X509
    {
        
        public static byte[] merrCelesinPublik() {
          
            string Certificate = "Certificate.pem"; 
            X509Certificate2 cert = new X509Certificate2(File.ReadAllBytes(Certificate), "123456", X509KeyStorageFlags.MachineKeySet);

            byte[] celesipublik = cert.GetPublicKey();
            //string result = System.Convert.ToBase64String(celesipublik)    
            
            return cert.GetPublicKey();
        }
    }
}
