﻿using System.Globalization;
using System.Resources;
using System.Threading;

namespace Domain.Validator.Resources
{
    public static class ResourcesReader
    {
        static ResourcesReader()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("pt-BR");
        }

        public static string Field(string fieldName)
        {
            try
            {
                ResourceManager resourceManager = new ResourceManager("Domain.Validator.Resources.Fields",
                    typeof(Fields).Assembly);

                return resourceManager.GetString(fieldName);
            }
            catch
            {
                return string.Empty;
            }
        }

        public static string Message(string message)
        {
            try
            {
                ResourceManager resourceManager = new ResourceManager("Domain.Validator.Resources.Messages",
                    typeof(Messages).Assembly);

                return resourceManager.GetString(message);
            }
            catch
            {
                return string.Empty;
            }
        }

        public static string ValidationMessage(string message)
        {
            try
            {
                ResourceManager resourceManager = new ResourceManager("Domain.Validator.Resources.ValidationMessages",
                    typeof(ValidationMessages).Assembly);

                return resourceManager.GetString(message);
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}
