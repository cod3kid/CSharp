using System;

public class Nullable<T>{
    
    private object _value;
    
    public Nullable(){}
    
    
    public Nullable(T value){
        _value = value;
    }
    
    public bool HasValue{
       get {return _value!=null;}
    }
    
    public T GetValueOrDefault(){
        if(HasValue){
            return (T)_value;
        }
        
        return default(T);
    }
}


public class HelloWorld
{
    public static void Main(string[] args)
    {
        var number = new Nullable<int>();
        Console.WriteLine(number.HasValue);
        Console.WriteLine(number.GetValueOrDefault());
    }
}