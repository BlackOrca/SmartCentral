namespace SmartCentral.Contracts.V1
{
    public static class ApiRoutes
    {
        public const string Root = "api";

        public const string Version = "v1";

        public const string Base = Root + "/" + Version;

        public static class Settings
        {
            public const string GetSpcSettings = Base + "/settings/spc";

            public const string UpdateSpcSettings = Base + "/settings/spc/{spcId}";

            public const string CreateSpcSettings = Base + "/settings/spc";

            public const string DeleteSpcSettings = Base + "/settings/spc/{spcId}";


            public const string GetSyncoLivingSettings = Base + "/settings/syncoliving";

            public const string UpdateSyncoLivingSettings = Base + "/settings/syncoliving/{syncoLivingId}";

            public const string CreateSyncoLivingSettings = Base + "/settings/syncoliving";

            public const string DeleteSyncoLivingSettings = Base + "/settings/syncoliving/{syncoLivingId}";
        }

        public static class Posts
        {
            public const string GetAll = Base + "/posts";

            public const string Update = Base + "/posts/{postId}";

            public const string Delete = Base + "/posts/{postId}";

            public const string Get = Base + "/posts/{postId}";

            public const string Create = Base + "/posts";
        }
        
        public static class Tags
        {
            public const string GetAll = Base + "/tags";
            
            public const string Get = Base + "/tags/{tagName}";
            
            public const string Create = Base + "/tags";
            
            public const string Delete = Base + "/tags/{tagName}";
        }

        public static class Identity
        {
            public const string Login = Base + "/identity/login";
            
            public const string Register = Base + "/identity/register";
            
            public const string Refresh = Base + "/identity/refresh";
        }
    }
}