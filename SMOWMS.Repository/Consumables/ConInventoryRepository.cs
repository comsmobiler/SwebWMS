using System.Linq;
using SMOWMS.Domain.Entity;
using SMOWMS.Domain.IRepository;
using SMOWMS.Infrastructure;

namespace SMOWMS.Repository.Consumables
{
    /// <summary>
    /// 盘点单的查询实现
    /// </summary>
    public class ConInventoryRepository : BaseRepository<ConInventory>, IConInventoryRepository
    {
        /// <summary>
        /// 盘点单查询类的构造函数
        /// </summary>
        /// <param name="dbContext">数据库上下文</param>
        public ConInventoryRepository(IDbContext dbContext)
            : base(dbContext)
        { }

        /// <summary>
        /// 根据盘点单编号得到盘点单信息
        /// </summary>
        /// <param name="IID"></param>
        /// <returns></returns>
        public IQueryable<ConInventory> GetConInventoryByID(string IID)
        {
            return _entities.Where(a => a.IID == IID);
        }

        /// <summary>
        /// 得到最大编号
        /// </summary>
        /// <returns></returns>
        public string GetMaxId()
        {
            return _entities.Select(a => a.IID).Max();
        }
    }
}
