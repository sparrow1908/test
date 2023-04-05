using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;
using NSwag;
using NSwag.CodeGeneration.CSharp;
using System;
using System.Threading;
using System.IO;

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



            //НЕВЕРНО

            StreamWriter sw1 = new StreamWriter("C:\\Users\\sparr\\Desktop\\Практика\\1\\message.txt");

            int i = code.IndexOf("[System.CodeDom.Compiler.GeneratedCode");
            while (i != -1)
            {
                i += 125;
                sw1.WriteLine(i.ToString());
                string subcode = code.Substring(i, 50);
                string[] words = subcode.Split(' ', (char)2); //class
                if (words[1].CompareTo("MyClass") != 0)
                {
                    if (words[1].EndsWith(":") == false)
                        code.Insert(i + words[0].Length, ": ActionResponse, ExecutableRequest");
                    sw1.WriteLine(words[1] + "yes");

                }
                else sw1.WriteLine(words[0] + words[1] + "no");
                i = code.IndexOf("[System.CodeDom.Compiler.GeneratedCode", i);
            }

            sw1.Close();

            StreamWriter sw = new StreamWriter("C:\\Users\\sparr\\Desktop\\Практика\\1\\code.cs");
            sw.WriteLine(code);
            sw.Close();



            return true;
        }
    }
}
