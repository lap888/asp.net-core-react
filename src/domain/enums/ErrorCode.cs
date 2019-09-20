using System.ComponentModel;
namespace domain.enums
{
    public enum ErrorCode
    {
        [Description("未授权")]
        Unauthorized = 403,
        [Description("系统错误")]
        SystemError = 503,
        [Description("请重新登录")]
        ReLogin = 10001,
        [Description("非法token")]
        InvalidToken = 10002,
    }
}