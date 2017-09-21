using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManage.model
{
    public class task
    {
        /// <summary>
        /// 键值
        /// </summary>
        public string id { set; get; }

        /// <summary>
        /// 任务内容
        /// </summary>
        public string taskcontent { set; get; }

        /// <summary>
        /// 负责人
        /// </summary>
        public string keeper { set; get; }

        /// <summary>
        /// 项目创建时间
        /// </summary>
        public string createdate { set; get; }

        /// <summary>
        /// 项目完成时间
        /// </summary>
        public string completedate { set; get; }

        /// <summary>
        /// 任务状态
        /// </summary>
        public string taskstatus { set; get; }
    }
}
