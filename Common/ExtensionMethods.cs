using Common.Communication;
using System;

namespace Common
{
    public static class ExtensionMethods
    {
        public static T ConvertResponse<T>(this Response res)
        {
            if (res.Exception != null) throw res.Exception;

            if (res.Success == false) throw new Exception(res.Message);

            return (T)res.Data;

        }
    }
}
