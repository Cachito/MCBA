﻿using Mcba.Infraestruture.Enums;

namespace Mcba.Infraestruture.Settings
{
    public class InstanceSettings
    {
        public string Key { set; get; }
        public string Salt { set; get; }
        public string CnnString { set; get; }
        public LanguageEnum Language { set; get; }
        public string MessageTitle { set; get; }
        public int MaxLoginAttemps { set; get; }
        public int RandomPassLength { set; get; }
        public int NumberOfNonAlphanumericCharacters { set; get; }
        public string EmailFrom { set; get; }
        public int EmailPort { set; get; }
        public string EmailHost { set; get; }
        public bool EmailSsl { set; get; }
        public string EmailPass { set; get; }
        public string TempFolder { set; get; }
        public int DataPagination { set; get; }
    }
}