//Для работ с базой данныхБ при условии если основная тупит то прокси дублирует базу но тольео что запросил пользователь

namespace Proxy
{
    public interface ISubject
    {
        void Request();
    }

    public class RealSubject : ISubject
    {
        public void Request()
        {
        }
    }

    public class Proxy : ISubject
    {
        public void Request()
        {
        }
    }

}