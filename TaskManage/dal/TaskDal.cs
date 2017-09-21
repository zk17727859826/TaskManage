using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;
using TaskManage.model;

namespace TaskManage.dal
{
    public class TaskDal
    {
        private const string TASK_FILE_PATH = "data/task.xml";
        /// <summary>
        /// 载入任务文件
        /// </summary>
        /// <returns></returns>
        private XElement LoadTaskRoot()
        {
            XElement root = XElement.Load(TASK_FILE_PATH);
            return root;
        }

        private List<task> ToModelList(IEnumerable<XElement> xmlst)
        {
            List<task> tasklst = new List<task>();
            if (xmlst == null || xmlst.Count() == 0) return tasklst;
            foreach (XElement xml in xmlst)
            {
                task tsk = new task()
                {
                    id = xml.Element("id").Value,
                    taskcontent = xml.Element("taskcontent").Value,
                    createdate = xml.Element("createdate").Value,
                    completedate = xml.Element("completedate").Value,
                    keeper = xml.Element("keeper").Value,
                    taskstatus = xml.Element("taskstatus").Value
                };
                tasklst.Add(tsk);
            }
            return tasklst;
        }

        /// <summary>
        /// 载入所有任务
        /// </summary>
        /// <param name="status">任务状态</param>
        /// <returns></returns>
        public List<task> LoadTask(string status)
        {
            XElement root = LoadTaskRoot();
            IEnumerable<XElement> tasklist = null;
            if (!string.IsNullOrEmpty(status) && status != "4" && status != "3")
            {
                tasklist = root.XPathSelectElements("task[taskstatus='" + status + "']");
            }
            else if (status == "3")
            {
                tasklist = root.XPathSelectElements("task[taskstatus='0' or taskstatus='1']");
            }
            else
            {
                tasklist = root.XPathSelectElements("task");
            }
            return ToModelList(tasklist);
        }

        /// <summary>
        /// 新增任务
        /// </summary>
        /// <param name="content">任务内容</param>
        /// <param name="keeper">负责人</param>
        /// <returns></returns>
        public bool InsertTask(string content, string keeper)
        {
            string createdate = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            string id = Guid.NewGuid().ToString().ToUpper().Replace("-", "");

            XElement root = LoadTaskRoot();
            XElement newnode = XElement.Parse(string.Format(@"<task>
                                                    <id>{0}</id>
                                                    <taskcontent><![CDATA[{1}]]></taskcontent>
                                                    <keeper><![CDATA[{2}]]></keeper>
                                                    <taskstatus>{3}</taskstatus>
                                                    <createdate>{4}</createdate>
                                                    <completedate>{5}</completedate>
                                                </task>", id, content, keeper, 0, createdate, ""));
            root.Add(newnode);
            root.Save(TASK_FILE_PATH);
            return true;
        }

        /// <summary>
        /// 更新任务内容
        /// </summary>
        /// <param name="id">任务ID</param>
        /// <param name="content">任务内容</param>
        /// <param name="keeper">负责人</param>
        /// <returns></returns>
        public bool UpdateTask(string id, string content, string keeper)
        {
            XElement root = LoadTaskRoot();
            XElement taskinfo = root.XPathSelectElement("task[id='" + id + "']");
            if (taskinfo == null)
            {
                throw new Exception("要编辑的任务不存在");
            }
            else
            {
                taskinfo.Element("taskcontent").Value = content;
                taskinfo.Element("keeper").Value = keeper;
                root.Save(TASK_FILE_PATH);
            }
            return true;
        }

        /// <summary>
        /// 删除任务信息
        /// </summary>
        /// <param name="id">任务ID</param>
        /// <returns></returns>
        public bool DeleteTask(string id)
        {
            XElement root = LoadTaskRoot();
            XElement taskinfo = root.XPathSelectElement("task[id='" + id + "']");
            if (taskinfo == null)
            {
                throw new Exception("要删除的任务不存在");
            }
            else
            {
                taskinfo.Remove();
                root.Save(TASK_FILE_PATH);
            }
            return true;
        }

        /// <summary>
        /// 完成任务
        /// </summary>
        /// <param name="id">任务ID</param>
        /// <returns></returns>
        public bool CompleteTask(string id)
        {
            XElement root = LoadTaskRoot();
            XElement taskinfo = root.XPathSelectElement("task[id='" + id + "']");
            if (taskinfo == null)
            {
                throw new Exception("要完成的任务不存在");
            }
            else
            {
                taskinfo.Element("taskstatus").Value = "1";
                taskinfo.Element("completedate").Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                root.Save(TASK_FILE_PATH);
            }
            return true;
        }

        /// <summary>
        /// 完工检查确认
        /// </summary>
        /// <param name="id">任务ID</param>
        /// <returns></returns>
        public bool VerifyTask(string id)
        {
            XElement root = LoadTaskRoot();
            XElement taskinfo = root.XPathSelectElement("task[id='" + id + "']");
            if (taskinfo == null)
            {
                throw new Exception("要操作的任务不存在");
            }
            else
            {
                taskinfo.Element("taskstatus").Value = "2";
                if (taskinfo.Element("verifydate") != null)
                {
                    taskinfo.Element("verifydate").Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                }
                else
                {
                    taskinfo.Add(new XElement("verifydate", DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")));
                }
                root.Save(TASK_FILE_PATH);
            }
            return true;
        }

        /// <summary>
        /// 获得单个任务信息
        /// </summary>
        /// <param name="id">任务ID</param>
        /// <returns></returns>
        public task GetTask(string id)
        {
            task tsk = null;
            XElement root = LoadTaskRoot();
            XElement taskinfo = root.XPathSelectElement("task[id='" + id + "']");
            if (taskinfo == null)
            {
                throw new Exception("要编辑的任务不存在");
            }
            else
            {
                tsk = new task()
                {
                    id = taskinfo.Element("id").Value,
                    taskcontent = taskinfo.Element("taskcontent").Value,
                    completedate = taskinfo.Element("completedate").Value,
                    createdate = taskinfo.Element("createdate").Value,
                    taskstatus = taskinfo.Element("taskstatus").Value,
                    keeper = taskinfo.Element("keeper").Value
                };
            }
            return tsk;
        }
    }
}
