using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.Serialization;

namespace Koobits.PeerChallenge.Application.Common.Exceptions
{
    //not using for now, currently exceptions are captured with ExtendedApiController
    public class ServiceException: Exception, ISerializable
    {
        
        public int ErrorCode;
        public new string Message;
        public string Description;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="inEnum"></param>
        public ServiceException(Enum penum, string pMessage = "") : base(GetDescription(penum))
        {
            ErrorCode = Convert.ToInt32(penum);
            Message = penum.ToString();
            Description = string.IsNullOrEmpty(pMessage) ? GetDescription(penum) : pMessage;
        }

        /// <summary>
        /// Get Description
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetDescription(System.Enum value)
        {
            Type type = value.GetType();
            string name = System.Enum.GetName(type, value);
            if (name != null)
            {
                FieldInfo field = type.GetField(name);
                if (field != null && Attribute.GetCustomAttribute(field,
                    typeof(DescriptionAttribute)) is DescriptionAttribute attr)
                    return attr.Description;
            }
            return null;
        }
    }

    
}
