using Common.Models;
using System;
using System.Collections.Generic;

namespace MovieAPI.Repositories
{
    public interface IMongoRepositories<T> where T : MongoDocument
    {
        List<T> GetAllRecords();
        T InsertRecord (T record);
        T GetRecordById (Guid id);
        void UpsertRecord(T record);
        void DeleteRecord(Guid id);

    }
}
