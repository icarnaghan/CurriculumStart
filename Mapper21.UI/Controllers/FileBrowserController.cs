using System.IO;
using System.Web.Mvc;
using Kendo.Mvc.UI;

namespace Mapper21.UI.Controllers
{
    public class FileBrowserController : EditorFileBrowserController
    {
        private const string contentFolderRoot = "~/Content/";
        private const string prettyName = "Images/";
        private static readonly string[] foldersToCopy = new[] { "~/Content/shared/" };
        private int _id;

        /// <summary>
        /// Gets the base paths from which content will be served.
        /// </summary>
        //public override string ContentPath
        //{
        //    get
        //    {
        //        return CreateUserFolder();
        //    }
        //}

        public override string ContentPath
        {
            get
            {
                //return "~/Content/UserFiles/" + id;
                return CreateUserFolder();
            }
        }

        public JsonResult MyRead(string path, int id)
        {
            _id = id;
            return base.Read(contentFolderRoot);
        }

        /// <summary>
        /// Gets the valid file extensions by which served files will be filtered.
        /// </summary>
        public override string Filter
        {
            get
            {
                return "*.txt, *.doc, *.docx, *.xls, *.xlsx, *.ppt, *.pptx, *.zip, *.rar, *.jpg, *.jpeg, *.gif, *.png";
            }
        }

        private string CreateUserFolder()
        {
            var virtualPath = Path.Combine(contentFolderRoot, "UserFiles", prettyName);

            var path = Server.MapPath(virtualPath);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                foreach (var sourceFolder in foldersToCopy)
                {
                    CopyFolder(Server.MapPath(sourceFolder), path);
                }
            }
            return virtualPath;
        }

        private void CopyFolder(string source, string destination)
        {
            if (!Directory.Exists(destination))
            {
                Directory.CreateDirectory(destination);
            }

            foreach (var file in Directory.EnumerateFiles(source))
            {
                var dest = Path.Combine(destination, Path.GetFileName(file));
                System.IO.File.Copy(file, dest);
            }

            foreach (var folder in Directory.EnumerateDirectories(source))
            {
                var dest = Path.Combine(destination, Path.GetFileName(folder));
                CopyFolder(folder, dest);
            }
        }
    }
}
