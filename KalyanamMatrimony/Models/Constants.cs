using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KalyanamMatrimony.Models
{
    public class Constants
    {
        public class InstamojoConstants
        {
            public const string INSTA_CLIENT_ID_TEST = "test_HB3puOS8s0eYFJKLUzCudIrM2BAGQTW4Tnp";
            public const string INSTA_CLIENT_SECRET_TEST = "test_BPW8BQCLzhdZ0ECSbFjtWVj97bgcvmDfVtdt6n5XA6yx1ZGAdqq90dc7uIaGay8DeXhQHbUzSBM52t0vb6E3UP2DajG0euygoaAJGw5CLObsTEWsbecY7sVbsNF";
            public const string INSTAMOJO_AUTH_ENDPOINT_TEST = "https://test.instamojo.com/oauth2/token/";
            public const string INSTAMOJO_API_ENDPOINT_TEST = "https://test.instamojo.com/v2/";
            public const string GRANT_TYPE = "client_credentials";
            public const string INSTA_CLIENT_ID = "test_HB3puOS8s0eYFJKLUzCudIrM2BAGQTW4Tnp";
            public const string INSTA_CLIENT_SECRET = "test_BPW8BQCLzhdZ0ECSbFjtWVj97bgcvmDfVtdt6n5XA6yx1ZGAdqq90dc7uIaGay8DeXhQHbUzSBM52t0vb6E3UP2DajG0euygoaAJGw5CLObsTEWsbecY7sVbsNF";
            public const string INSTAMOJO_AUTH_ENDPOINT = "https://test.instamojo.com/oauth2/token/";
            public const string INSTAMOJO_API_ENDPOINT = "https://test.instamojo.com/v2/";

            public const string INSTA_AFTER_PAYMENT_REDIRECT_URL = "http://localhost:49831/License/AcknowledgeLicense";
            public const string INSTA_AFTER_PAYMENT_WEBHOOK_URL = "http://parinayam.in/";

            public const string INSTA_STATUS_CREDIT = "Credit";
            public const string INSTA_STATUS_COMPLETED = "Completed";
            public const string INSTA_STATUS_FAILED = "Failed";
            public const string INSTA_STATUS_PENDING = "Pending";
        }
    }
}
