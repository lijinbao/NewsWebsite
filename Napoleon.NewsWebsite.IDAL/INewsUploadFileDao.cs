
using System.Collections.Generic;
using System.Data;
using Napoleon.NewsWebsite.Model;

namespace Napoleon.NewsWebsite.IDAL
{
    public interface INewsUploadFileDao
    {

        /// <summary>
        ///  ��ѯ����
        /// </summary>
        /// Author  :Napoleon
        /// Created :2015-06-06 02:02:28
        DataTable GetNewsUploadFileTable(string id);

        /// <summary>
        ///  ����ID�����ѯ����
        /// </summary>
        /// Author  :Napoleon
        /// Created :2015-06-13 10:54:06
        List<NewsUploadFile> GetNewsUploadFilesByIds(string id);

        /// <summary>
        ///  ��������
        /// </summary>
        /// Author  :Napoleon
        /// Created :2015-06-06 02:02:28
        int InsertNewsUploadFile(NewsUploadFile model);

        /// <summary>
        ///  ��������
        /// </summary>
        /// Author  :Napoleon
        /// Created :2015-06-06 02:02:28
        int UpdateNewsUploadFile(NewsUploadFile model);

        /// <summary>
        ///  ɾ������
        /// </summary>
        /// Author  :Napoleon
        /// Created :2015-06-06 02:02:28
        int DeleteNewsUploadFile(string id);

    }
}