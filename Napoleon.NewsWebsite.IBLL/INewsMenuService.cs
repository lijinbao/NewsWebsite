
using System.Data;
using Napoleon.NewsWebsite.Model;

namespace Napoleon.NewsWebsite.IBLL
{
    public interface INewsMenuService
    {

        /// <summary>
        ///  ��ȡ�˵��б�����
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2015-06-09 10:59:11
        DataTable GetNewsMenuGrid(string isUse, string parentId = "-1");

        /// <summary>
        ///  ��ѯ���˵�����
        /// </summary>
        /// Author  :Napoleon
        /// Created :2015-06-06 02:02:25
        DataTable GetNewsMenuParentTable(string isParent);

        /// <summary>
        ///  ��ѯ����
        /// </summary>
        /// Author  :Napoleon
        /// Created :2015-06-06 02:02:25
        DataTable GetNewsMenuTable(string id);

        /// <summary>
        ///  ��������
        /// </summary>
        /// Author  :Napoleon
        /// Created :2015-06-06 02:02:25
        int InsertNewsMenu(NewsMenu model);

        /// <summary>
        ///  ��������
        /// </summary>
        /// Author  :Napoleon
        /// Created :2015-06-06 02:02:25
        int UpdateNewsMenu(NewsMenu model);

        /// <summary>
        ///  ɾ������
        /// </summary>
        /// Author  :Napoleon
        /// Created :2015-06-06 02:02:25
        int DeleteNewsMenu(string id);

    }
}