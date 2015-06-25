
using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using Napoleon.NewsWebsite.IBLL;
using Napoleon.NewsWebsite.IDAL;
using Napoleon.NewsWebsite.Model;

namespace Napoleon.NewsWebsite.BLL
{

    public class NewsContentsService : INewsContentsService
    {

        private INewsContentsDao _newscontentsDao;
        private INewsUploadFileDao _newsUploadFileDao;

        public NewsContentsService(INewsContentsDao newscontentsDao, INewsUploadFileDao newsUploadFileDao)
        {
            _newscontentsDao = newscontentsDao;
            _newsUploadFileDao = newsUploadFileDao;
        }

        /// <summary>
        ///  ��ȡ���������б�
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2015-06-19 10:25:30
        public DataTable GetNewsContents(string newsMenuId, string newsTitle, string newsType,
            int start, int end)
        {
            return _newscontentsDao.GetNewsContents(newsMenuId, newsTitle, newsType, start, end);
        }

        /// <summary>
        ///  ��ȡ���������б������
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2015-06-19 11:04:39
        public int GetNewsContentsCount(string newsMenuId, string newsTitle, string newsType)
        {
            return _newscontentsDao.GetNewsContentsCount(newsMenuId, newsTitle, newsType);
        }

        /// <summary>
        ///  ����ID��ѯ��������
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// Author  : Napoleon
        /// Created : 2015-06-24 14:49:57
        public DataTable GetNewsContentById(string id)
        {
            return _newscontentsDao.GetNewsContentById(id);
        }

        /// <summary>
        ///  ��ѯ����
        /// </summary>
        /// Author  :Napoleon
        /// Created :2015-06-06 02:02:20
        public DataTable GetNewsContentsTable(string id)
        {
            return _newscontentsDao.GetNewsContentsTable(id);
        }

        /// <summary>
        ///  ��������
        /// </summary>
        /// Author  :Napoleon
        /// Created :2015-06-06 02:02:20
        public int InsertNewsContents(NewsContents model)
        {
            return _newscontentsDao.InsertNewsContents(model);
        }

        /// <summary>
        ///  ��������
        /// </summary>
        /// Author  :Napoleon
        /// Created :2015-06-06 02:02:20
        public int UpdateNewsContents(NewsContents model)
        {
            return _newscontentsDao.UpdateNewsContents(model);
        }

        /// <summary>
        ///  ������˽��
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2015-06-25 11:14:48
        public int UpdateNewsVerify(string id, string verifyId)
        {
            return _newscontentsDao.UpdateNewsVerify(id, verifyId);
        }

        /// <summary>
        ///  ɾ������
        /// </summary>
        /// Author  :Napoleon
        /// Created :2015-06-06 02:02:20
        public int DeleteNewsContents(string ids)
        {
            int i;
            try
            {
                List<NewsContents> contents = _newscontentsDao.GetNewsContentsByIds(ids);//��ѯ�������ݼ���
                string uploadIds = GetNewsByList(contents);//��װ�ϴ��ļ�Id
                List<NewsUploadFile> uploadFiles = _newsUploadFileDao.GetNewsUploadFilesByIds(uploadIds);//��ѯ�ϴ��ļ�����
                _newscontentsDao.DeleteNewsContents(ids);//ɾ����������
                _newsUploadFileDao.DeleteNewsUploadFile(uploadIds);//ɾ���ϴ��ļ�����
                //ɾ���ϴ��ļ�
                foreach (NewsUploadFile file in uploadFiles)
                {
                    if (System.IO.File.Exists(HttpContext.Current.Server.MapPath(file.FileUrl)))
                    {
                        System.IO.File.Delete(HttpContext.Current.Server.MapPath(file.FileUrl));
                    }
                }
                i = 1;
            }
            catch (Exception)
            {
                i = -1;
            }
            return i;
        }

        /// <summary>
        ///  �������������ļ���ID���
        /// </summary>
        /// Author  : Napoleon
        /// Created : 0001-01-01 00:00:00
        private string GetNewsByList(List<NewsContents> contents)
        {
            string uploadIds = "";
            foreach (NewsContents content in contents)
            {
                if (!string.IsNullOrWhiteSpace(content.AttachId))
                {
                    uploadIds += content.AttachId + ",";
                }
                if (!string.IsNullOrWhiteSpace(content.IndexImg))
                {
                    uploadIds += content.IndexImg + ",";
                }
                if (!string.IsNullOrWhiteSpace(content.AttachContent1))
                {
                    uploadIds += content.AttachContent1 + ",";
                }
                if (!string.IsNullOrWhiteSpace(content.AttachContent2))
                {
                    uploadIds += content.AttachContent2 + ",";
                }
                if (!string.IsNullOrWhiteSpace(content.AttachContent3))
                {
                    uploadIds += content.AttachContent3 + ",";
                }
                if (!string.IsNullOrWhiteSpace(content.AttachContent4))
                {
                    uploadIds += content.AttachContent4 + ",";
                }
            }
            return uploadIds.Trim(',');
        }

    }
}