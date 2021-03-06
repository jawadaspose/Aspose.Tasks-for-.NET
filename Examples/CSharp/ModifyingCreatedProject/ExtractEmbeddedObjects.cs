using System.IO;

namespace Aspose.Tasks.Examples.CSharp.ModifyingCreatedProject
{
    public class ExtractEmbeddedObjects
    {
        public static void Run()
        {
            // ExStart:ExtractEmbeddedObjects
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingCreatedProject();
            Project project = new Project(dataDir + "Project1.mpp");
            OleObject ole = project.OleObjects.ToList()[0];

            // we have to check this property because it can be null if the embedded object was created inside the ms project application Or, alternatively, you can use this check: if (ole.FileFormat == "Package")
            if (!string.IsNullOrEmpty(ole.FullPath))
            {
                using (FileStream fileStream = new FileStream(dataDir, FileMode.Create))
                    fileStream.Write(ole.Content, 0, ole.Content.Length);
            }
            // ExEnd:ExtractEmbeddedObjects
        }
    }
}