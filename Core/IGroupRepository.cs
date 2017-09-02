using System.Threading.Tasks;
using TomatoKindergarten.Core.Models;

namespace TomatoKindergarten.Core
{
    public interface IGroupRepository
    {
         Task<Group> GetGroup(int id, bool includeRelated = true);
         void Add(Group group);
         void Remove(Group group);
    }
}