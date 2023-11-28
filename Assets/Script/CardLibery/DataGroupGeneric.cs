using System.Collections.Generic;

public class DataGroupGeneric<T1,T2>
{
    Dictionary<T1,T2> _dataDic;

    public DataGroupGeneric()
    {
        _dataDic = new();
    }

    void RegisterData(T1 key,T2 value, out bool isSuccess) => isSuccess = _dataDic.TryAdd(key,value);
  
    void RegisterData(Dictionary<T1,T2> dataDic)
    {
        foreach(var item in dataDic)
        {
            this._dataDic.TryAdd(item.Key,item.Value);
        }
    }

    T2 GetSingleData(T1 key) => _dataDic[key];

    Dictionary<T1,T2> GetDataDic()
    {
        Dictionary<T1,T2> result = new();
        return result;
    }

    

}
