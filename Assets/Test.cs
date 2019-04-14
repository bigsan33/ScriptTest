using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss{
    private int mp = 53;   //魔法力

    //魔法攻撃用の関数
    public void Magic(int usedmp){
        if (mp >= usedmp){
            //残りmpを減らす
            this.mp -= usedmp;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp);
        } else {
            Debug.Log("MPが足りないため魔法が使えない");
        }

    }
}


public class Test : MonoBehaviour{
    // Start is called before the first frame update
    void Start(){
        //Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        //魔法攻撃の関数を呼び出す
        for(int i = 0; i < 10; i++){
            lastboss.Magic(5);
        }
        lastboss.Magic(5);



        //配列を初期化する
        int[] array = { 10, 20, 30, 40, 50 };
        //配列の要素が50以上の場合
        for (int i = 0; i < array.Length; i++){
            Debug.Log(array[i]);
        }

        for (int j = array.Length - 1 ; j >= 0; j--){
            Debug.Log(array[j]);
        }

    }

    // Update is called once per frame
    void Update(){
        
    }
}