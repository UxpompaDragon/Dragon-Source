using db;
using System.IO;
using System.Text;

namespace server.account
{
    internal class validateEmail : RequestHandler
    {
        void WriteStream(string str)
        {
            Context.Response.OutputStream.Write(Encoding.ASCII.GetBytes(str),0,str.Length);
        }
        protected override void HandleRequest()
        {
            using (Database db = new Database())
            {
                var cmd = db.CreateQuery();
                cmd.CommandText = "UPDATE accounts SET verified=1 WHERE authToken=@authToken";
                cmd.Parameters.AddWithValue("@authToken", Query["authToken"]);
                using (StreamWriter wtr = new StreamWriter(Context.Response.OutputStream))
                {
                    if (cmd.ExecuteNonQuery() == 1)
                        WriteStream("<h1>Verified succesfully!</h1>");
                    else
                        WriteStream("<h1>Verification has failed!</h1>");
                }
            }
        }
    }
}
