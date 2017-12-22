#region


#endregion

namespace server.sfx
{
    internal class Sfx : RequestHandler
    {
        protected override void HandleRequest()
        {
            string file = Context.Request.Url.LocalPath.StartsWith("/music") ? "sfx/" + Context.Request.Url.LocalPath : Context.Request.Url.LocalPath;
			
                Context.Response.Redirect("http://realmofthemadgod.appspot.com/" +
                                          (file.Split('/')[1].Contains("music")
                                              ? file.Replace("sfx/", string.Empty)
                                              : file));
        }
    }
}