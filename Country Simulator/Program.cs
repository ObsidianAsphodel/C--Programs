using System;
using System.Collections.Generic;
namespace CountrySimulator;

//At the start of runtime, nodes are created and popped into the list

class Node{
    private string name;
    private int index;

    public Node(string name, int index){
        this.name = name;
        this.index = index;
    }

    public void WakeUpGreeting(){
        Console.WriteLine("I'm alive!");
    }
}

class CountrySimulator{

    public List<Node> nodeList = new List<Node>();

    private double seedGenerator(){
        double seed;
        var rand = new Random();

        return seed;
    }

    private static void PopulateCountry(){
        for(int i = 0; i >= 10; i++){
            Node newNode = new Node();
        }
    }
}