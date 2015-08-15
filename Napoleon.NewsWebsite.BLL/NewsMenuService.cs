
using System.Data;
using Napoleon.NewsWebsite.IBLL;
using Napoleon.NewsWebsite.IDAL;
using Napoleon.NewsWebsite.Model;

namespace Napoleon.NewsWebsite.BLL
{

    public class NewsMenuService : INewsMenuService
    {

        private INewsMenuDao _newsmenuDao;

        public NewsMenuService(INewsMenuDao newsmenuDao)
        {
            _newsmenuDao = newsmenuDao;
        }

        /// <summary>
        ///  ��ȡ�˵��б�����
        /// </summary>
        /// Author  : Napoleon
        /// Created : 2015-06-09 10:59:11
        public DataTable GetNewsMenuGrid(string isUse, string parentId = "-1")
        {
            return _newsmenuDao.GetNewsMenuGrid(isUse, parentId);
        }

        /// <summary>
        ///  ��ѯ���˵�����
        /// </summary>
        /// Author  :Napoleon
        /// Created :2015-06-06 02:02:25
        public DataTable GetNewsMenuParentTable(string isParent)
        {
            return _newsmenuDao.GetNewsMenuParentTable(isParent);
        }

        /// <summary>
        ///  ��ѯ�Ƿ����Ӳ˵�����
        /// </summary>
        /// Author  :Napoleon
        /// Created :2015-06-06 02:02:25
        public DataTable GetNewsMenuParentId(string parentId)
        {
            return _newsmenuDao.GetNewsMenuParentId(parentId);
        }

        /// <summary>
        ///  ��ѯ����
        /// </summary>
        /// Author  :Napoleon
        /// Created :2015-06-06 02:02:25
        public DataTable GetNewsMenuTable(string id)
        {
            return _newsmenuDao.GetNewsMenuTable(id);
        }

        /// <summary>
        ///  ��������
        /// </summary>
        /// Author  :Napoleon
        /// Created :2015-06-06 02:02:25
        public int InsertNewsMenu(NewsMenu model)
        {
            return _newsmenuDao.InsertNewsMenu(model);
        }

        /// <summary>
        ///  ��������
        /// </summary>
        /// Author  :Napoleon
        /// Created :2015-06-06 02:02:25
        public int UpdateNewsMenu(NewsMenu model)
        {
            return _newsmenuDao.UpdateNewsMenu(model);
        }

        /// <summary>
        ///  ɾ������
        /// </summary>
        /// Author  :Napoleon
        /// Created :2015-06-06 02:02:25
        public int DeleteNewsMenu(string id)
        {
            int i;
            DataTable dt = _newsmenuDao.GetNewsMenuParentId(id);
            if (dt.Rows.Count > 0)//���Ӳ˵�,��Ҫ��ɾ��
            {
                i = -1;
            }
            else
            {
                i = _newsmenuDao.DeleteNewsMenu(id);
            }
            return i;
        }

    }
}