using System.ComponentModel;

namespace MacWebApi.Enums
{
    public enum OrderStatus
    {
        [Description("Принят")]
        Accepted = 0,

        [Description("Подтвержден")]
        Confirmed = 1,

        [Description("Ожидает подтверждения")]
        AwaitingConfirmation = 2,

        [Description("Ошибка подтверждения")]
        ConfirmationError = 3,

        [Description("Отмена")]
        Cancelled = 4
    }
}

