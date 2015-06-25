
using System.Data;
using Napoleon.NewsWebsite.Model;

namespace Napoleon.NewsWebsite.IDAL
{
    public interface ISystemNavMenuDao
    {

        /// <summary>
        ///  ��ѯ����
        /// </summary>
        /// Author  :Napoleon
        /// Created :2015-06-06 02:02:44
        DataTable GetSystemNavMenuTable(string id);

        /// <summary>
        ///  ��ѯ����
        /// </summary>
        /// Author  :Napoleon
        /// Created :2015-06-06 02:02:44
        DataTable GetSystemNavMenuTable(string id, string isUsed);

        /// <summary>
        ///  ��������
        /// </summary>
        /// Author  :Napoleon
        /// Created :2015-06-06 02:02:44
        int InsertSystemNavMenu(SystemNavMenu model);

        /// <summary>
        ///  ��������
        /// </summary>
        /// Author  :Napoleon
        /// Created :2015-06-06 02:02:44
        int UpdateSystemNavMenu(SystemNavMenu model);

        /// <summary>
        ///  ɾ������
        /// </summary>
        /// Author  :Napoleon
        /// Created :2015-06-06 02:02:44
        int DeleteSystemNavMenu(string id);

    }
}