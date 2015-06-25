
using System.Data;
using Napoleon.NewsWebsite.Model;

namespace Napoleon.NewsWebsite.IBLL
{
    public interface ISystemCodeService
    {

        /// <summary>
        ///  ��ѯ����
        /// </summary>
        /// Author  :Napoleon
        /// Created :2015-06-06 02:02:41
        DataTable GetSystemCodeTable(string id);

        /// <summary>
        ///  ��������
        /// </summary>
        /// Author  :Napoleon
        /// Created :2015-06-06 02:02:41
        int InsertSystemCode(SystemCode model);

        /// <summary>
        ///  ��������
        /// </summary>
        /// Author  :Napoleon
        /// Created :2015-06-06 02:02:41
        int UpdateSystemCode(SystemCode model);

        /// <summary>
        ///  ɾ������
        /// </summary>
        /// Author  :Napoleon
        /// Created :2015-06-06 02:02:41
        int DeleteSystemCode(string id);

    }
}