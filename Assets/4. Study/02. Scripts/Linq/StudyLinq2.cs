using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class StudyLinq2 : MonoBehaviour
{
    [System.Serializable]
    public class Person
    {
        public string name;
        public int score;

        public Person(string name, int score)
        {
            this.name = name;
            this.score = score;
        }
    }

    public List<Person> persons = new List<Person>();
    public int cutline = 70;
    
    void Start()
    {
        persons.Add(new Person("John", 65));
        persons.Add(new Person("Sarah", 80));
        persons.Add(new Person("David", 95));
        persons.Add(new Person("Emily", 70));
        persons.Add(new Person("Michael", 50));
        CheckScore();
    }

    private void CheckScore()
    {
        // Linq ��� X
        // foreach (var person in persons)
        // {
        //     if (person.score >= cutline)
        //         Debug.Log(person.name); // ĿƮ���� ���� ���
        //     else
        //         Debug.Log(person.name); // ĿƮ���� �� ���� ���
        // }
        
        
        // Linq ��� O
        // var passPersons = from person in persons
        //                   where person.score >= cutline
        //                   select person;
        
        var passPersons = persons.Where(p => p.score >= cutline);
        var failPersons = persons.Except(passPersons);

        foreach (var p in passPersons)
            Debug.Log($"<color=green>{p.name}</color>");
        
        foreach (var p in failPersons)
            Debug.Log($"<color=red>{p.name}</color>");
    }
}