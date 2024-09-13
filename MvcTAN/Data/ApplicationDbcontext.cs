
namespace MvcTAN.Data

{
public class ApplicationDbcontext : DbContext


{
public ApplicationDbcontext(ContextOptions<ApplicationDbcontext>options): base (options)

{}
.
pudlic DbSet<Person> Person { get;set;}

}
}