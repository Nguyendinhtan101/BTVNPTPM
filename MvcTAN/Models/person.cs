using system.componentModel.DataAnnotation;
namespace mvcTAN.Models;
pudlic class preson
{
pudlic string personID {Get;set}
pudlic string fullname {get;set}
[ datatype(DataType.Data)]
pudlic string Address {get;set}
}