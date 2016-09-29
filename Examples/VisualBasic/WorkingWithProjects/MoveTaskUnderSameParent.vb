﻿Imports Aspose.Tasks.Saving
Imports Aspose.Tasks

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Tasks for .NET API reference 
'when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Tasks for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Tasks.Examples.VisualBasic.WorkingWithProjects
    Class MoveTaskUnderSameParent
        Public Shared Sub Run()
            ' The path to the documents directory.
            Try
                ' The path to the documents directory.
                Dim dataDir As String = RunExamples.GetDataDir_WorkingWithProjects()
                ' loading project file
                Dim project As New Project(dataDir & Convert.ToString("MoveTask.mpp"))


                Dim task As Task = project.RootTask.Children.GetById(5)

                ' Move tasks with id == 5 before task with id == 3
                task.MoveToSibling(3)

                ' Saving File To Disk
                project.Save(dataDir & Convert.ToString("MoveTaskUnderSameParent_out.mpp"), SaveFileFormat.MPP)

            Catch exception As Exception

                Console.WriteLine(exception.Message + vbLf & "This example will only work if you apply a valid Aspose BarCode License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.")

            End Try

        End Sub
    End Class
End Namespace