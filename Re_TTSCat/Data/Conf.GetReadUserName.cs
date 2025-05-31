namespace Re_TTSCat.Data
{
    public partial class Conf
    {
        public static string GetReadUserName(string sourceName)
        {
            if (Vars.CurrentConf.UserNameAlias != null 
                && Vars.CurrentConf.UserNameAlias.TryGetValue(sourceName, out string alias))
            {
                return alias ?? sourceName;
            }
            return sourceName;
        }
    }
}
