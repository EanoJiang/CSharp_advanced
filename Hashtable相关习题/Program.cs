using System.Collections;

for (int i = 0; i < 10; i++)
{
    MonsterManager.Instance.AddMonster();
}
MonsterManager.Instance.RemoveMonster(1);
MonsterManager.Instance.RemoveMonster(5);


class MonsterManager
{
    //要让管理器是唯一的 所以用单例模式来实现
    private static MonsterManager _instance = new MonsterManager();
    public static MonsterManager Instance
    {
        get
        {
            return _instance;
        }
    }

    private Hashtable monsterTable = new Hashtable();
    //不让在外面new
    private MonsterManager()
    {

    }

    private int monsterID = 0;
    public void AddMonster()
    {
        Monster monster = new Monster(monsterID);
        monsterTable.Add(monster.id, monster);
        (monsterTable[monsterID] as Monster).Generate();
        monsterID++;
    }

    public void RemoveMonster(int id)
    {
        if (monsterTable.ContainsKey(id))
        {
            (monsterTable[id] as Monster).Dead();
            monsterTable.Remove(id);
        }
    }
}

class Monster
{
    public int id;
    public Monster(int id)
    {
        this.id = id;
    }
    public void Generate()
    {
        Console.WriteLine("生成怪物{0}", id);
    }
    public void Dead()
    {
        Console.WriteLine("怪物{0}死亡", id);
    }
}