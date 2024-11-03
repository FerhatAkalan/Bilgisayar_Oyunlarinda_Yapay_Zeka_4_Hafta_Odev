using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DNA_sc
{
    List<int> genes = new List<int>();
    //DNA kodunun uzunluğunu saklar
    int dnaLength = 0;
    int maxValues = 0;
    public DNA_sc(int l, int v)
    {
        dnaLength = l;
        maxValues = v;
        SetRandom();
    }
    public void SetRandom()
    {
        genes.Clear();
        for(int i = 0; i < dnaLength ; i++){
            genes.Add(Random.Range(0, maxValues));
        }
    }
    public void SetInt(int pos, int value)
    {
        genes[pos] = value;
    }
    public int GetGene(int pos)
    {
        return genes[pos];
    }
    //DNA yarısını anneden yarısı babadan gelir
    public void Combine(DNA_sc d1, DNA_sc d2)
    {
        for(int i = 0; i < dnaLength; i++)
        {
            if(i < dnaLength/2.0)
            {
                genes[i] = d1.genes[i];
            }
            else
            {
                genes[i] = d2.genes[i];
            }
        }
    }
    public void Mutate()
    {
        genes[Random.Range(0, dnaLength)] = Random.Range(0, maxValues);
    }
}