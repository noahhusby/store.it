using Firebase.Auth;
using FireSharp;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store.it
{
    class Instance
    {
        public static IFirebaseClient firebase;
        /**
         * Checks authentication through firebase-auth from stepup then configures client using firesharp
         */
        public async Task<bool> login(String email, String password)
        {
            try
            {
                var authProvider = new FirebaseAuthProvider(new FirebaseConfig(Authentication.fbAuth));
                var auth = await authProvider.SignInWithEmailAndPasswordAsync(email, password);
                IFirebaseConfig config = new FireSharp.Config.FirebaseConfig
                {
                    AuthSecret = auth.FirebaseToken,
                    BasePath = Authentication.basePath
                };
                firebase = new FirebaseClient(config);
            } catch
            {
                return false;
            }
            return true;
        }
    }
}
