using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi2.Web.Api.Models
{
    public class Status
    {
        public long StatusId { get; set; }
        public string Name { get; set; }
        public int Ordinal { get; set; }
    }
}
