﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGame
{

    public abstract class IGame
    {
        
        public abstract void AddVar(string varName, int amt);
        public abstract void Debug(string s);
        public abstract int GetObjectAttr(int id, string name);
        public abstract int GetObjectId(string name);
        public abstract int GetObjectProp(int id, string name);
        public abstract int GetStringId(string s);
        public abstract int GetVarVal(string name);
        public abstract bool IsVariable(string name);
        public abstract void Look();
        public abstract void Move();
        public abstract void PrintString(int index);
        public abstract void PrintString(string message);
        public abstract void PrintStringCr(string str);
        public abstract void PrintStringCr(int strId);
        public abstract void PrintCr();
        public abstract void SetObjectAttr(int id, string name, int val);
        public abstract void SetVar(string name, int val);
        public abstract void CallFunction(string name);
            

    }

    public interface IGameXml
    {
        int GetObjectId(string name);
        int GetStringId(string s);
        bool IsVariable(string name);
        string GetVarAddr(string name);
    }
}
