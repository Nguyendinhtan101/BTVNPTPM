using system.componentModel.DataAnnotation;
namespace mvcTAN.Models;
{
[table ("person")]

pudlic class preson
{
    [Key]
pudlic string personID {Get;set}
pudlic string fullname {get;set}

pudlic string Address {get;set}
}
}