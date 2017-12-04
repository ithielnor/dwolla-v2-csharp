using System;
using System.Threading.Tasks;
using Dwolla.Client.Models.Requests;
using Dwolla.Client.Models;
using System.Reflection;

namespace ExampleApp.Tasks.Documents
{
    [Task("cd", "Create Document")]
    class Create : BaseTask
    {
        private const string FILENAME_SUCCESS = "test-document-upload-success.png";

        private static byte[] SuccesBytes
        {
            get
            {
                using (var resourceStream = typeof(Create).GetTypeInfo().Assembly.GetManifestResourceStream($"ExampleApp.{FILENAME_SUCCESS}"))
                {
                    var ba = new byte[resourceStream.Length];
                    resourceStream.Read(ba, 0, ba.Length);
                    return ba;
                }
            }
        }

        public override async Task Run()
        {
            Write("Customer ID for whom to upload a document: ");
            var input = ReadLine();

            var rootRes = await Broker.GetRootAsync();
            var res = await Broker.UploadDocumentAsync(new Uri($"{rootRes.Links["customers"].Href}/{input}/documents"),
                new UploadDocumentRequest { DocumentType = "idCard", Document = new File() { ContentType = "image/png", Filename = FILENAME_SUCCESS, Bytes = SuccesBytes } });
            
            WriteLine($"Customer document uploaded: URI={res.ToString()}");
        }
    }
}