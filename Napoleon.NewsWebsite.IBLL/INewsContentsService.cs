
using System.Collections.Generic;
using System.Data;
using Napoleon.NewsWebsite.Model;

namespace Napoleon.NewsWebsite.IBLL
{
    public interface INewsContentsService
    {

        /// <summary>
        ///  ��ȡ���������б�
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2015-06-19 10:25:30
        DataTable GetNewsContents(string newsMenuId, string newsTitle, string newsType,
            int start, int end);

        /// <summary>
        ///  ��ȡ���������б������
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2015-06-19 11:04:39
        int GetNewsContentsCount(string newsMenuId, string newsTitle, string newsType);

        /// <summary>
        ///  ����ID��ѯ��������
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// Author  : Napoleon
        /// Created : 2015-06-24 14:49:57
        DataTable GetNewsContentById(string id);

        /// <summary>
        ///  ���ݲ˵�ID��ѯ����
        /// </summary>
        /// Author  :Napoleon
        /// Created :2015-06-06 02:02:20
        DataTable GetNewsContentsTable(string newsMenuId, string newsStatus);

        /// <summary>
        ///  ���ݲ˵�ID��ѯ����
        /// </summary>
        /// Author  :Napoleon
        /// Created :2015-06-13 10:54:06
        DataTable GetNewsContentsForList(string newsMenuId, string newsStatus = "", int top = 0);

        /// <summary>
        ///  ��ѯ��ҳͼƬ,������������
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2015-08-13 14:08:00
        DataTable GetIndexImages(string newsStatus);

        /// <summary>
        ///  ����ID�����ѯ����
        /// </summary>
        /// Author  :Napoleon
        /// Created :2015-06-13 10:54:06
        List<NewsContents> GetNewsContentsByIds(string id);

        /// <summary>
        ///  ��������
        /// </summary>
        /// Author  :Napoleon
        /// Created :2015-06-06 02:02:20
        int InsertNewsContents(NewsContents model);

        /// <summary>
        ///  ��������
        /// </summary>
        /// Author  :Napoleon
        /// Created :2015-06-06 02:02:20
        int UpdateNewsContents(NewsContents model);

        /// <summary>
        ///  ������˽��
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2015-06-25 11:14:48
        int UpdateNewsVerify(string id, string verifyId);

        /// <summary>
        ///  ɾ������
        /// </summary>
        /// Author  :Napoleon
        /// Created :2015-06-06 02:02:20
        int DeleteNewsContents(string ids);

    }
}