using Ouatelse.Models;

namespace Ouatelse.Managers
{
    /// <summary>
    /// Interface qui permet de gérer nos managers en iutilisant les types Génériques
    /// </summary>
    /// <typeparam name="T">Le type dy manager</typeparam>
    public interface IManager<out T>
    {
        T[] All();
        T[] Filter(string filter);

        int Count(string filter = "");
        T Find(object id);

        bool Save(BaseModel model);
        bool Truncate();
    }
}
