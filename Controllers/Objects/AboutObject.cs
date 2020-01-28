namespace project_entropy.Controllers.Objects
{
    public class AboutObject
    {
        public string version { get; set; }
        public AboutObject(string version)
        {
            this.version = version;
            
        }
    }
}