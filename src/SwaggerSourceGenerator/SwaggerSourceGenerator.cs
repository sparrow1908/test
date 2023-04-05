using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using NSwag;
using NSwag.CodeGeneration.CSharp;
using System;
using System.Threading;

namespace SwaggerSourceGenerator
{
    public class SwaggerSourceGenerator : Task
    {

        [Required]
        public string SchemaPath { get; set; }

        [Required]
        public string OutputFolder { get; set; }


        public override bool Execute()
        {
            OpenApiDocument document;
            using (var webClient = new System.Net.WebClient())
            {
                var loadDocumentTask = OpenApiDocument.FromJsonAsync(webClient.DownloadString("https://petstore3.swagger.io/api/v3/openapi.json"));
                var cts = new CancellationTokenSource();
                cts.CancelAfter(TimeSpan.FromSeconds(10));
                System.Threading.Tasks.Task.WaitAny(new System.Threading.Tasks.Task[] { loadDocumentTask }, cts.Token);
                document = loadDocumentTask.Result;
            }

            var settings = new CSharpClientGeneratorSettings
            {
                ClassName = "MyClass",
                CSharpGeneratorSettings =
                {
                    Namespace = "MyNamespace"
                },
                InjectHttpClient = false
            };

            var generator = new CSharpClientGenerator(document, settings);
            var code = generator.GenerateFile();

            return true;
        }
    }
}
