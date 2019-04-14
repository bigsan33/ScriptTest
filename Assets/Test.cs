using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int mp = 53;   //魔法力

    //魔法攻撃用の関数
    public void Magic(int usedmp)
    {
        if (mp > usedmp)
        {
            //残りmpを減らす
            this.mp -= usedmp;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp);

        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない");
        }

    }
}

//public class Boss
//{
//    private int mp = 100;   //体力
//    private int power = 25; //攻撃力

//    //攻撃用の関数
//    public void Attack()
//    {
//        Debug.Log( this.power + "のダメージを与えた" );
//    }

//    //防御用の関数
//    public void Defence(int damage)
//    {
//        Debug.Log( damage + "のダメージを受けた");
//        //残りhpを減らす
//        this.hp -= damage;
//    }
//}

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        //魔法攻撃の関数を呼び出す

        for(int i = 0; i < 10; i++)
        {
            lastboss.Magic(5);
        }

        lastboss.Magic(5);

        ////攻撃用の関数を呼び出す
        //lastboss.Attack();
        ////防御用の関数を呼び出す
        //lastboss.Defence(3);









        ////配列を初期化する
        //int[] array = { 10, 20, 30, 40, 50 };
        ////配列の要素が50以上の場合
        //for (int i = 0; i < array.Length; i++)
        //{
        //    Debug.Log(array[i]);
        //}

        //for (int j = array.Length - 1 ; j >= 0; j--)
        //{
        //    Debug.Log(array[j]);
        //}










        ////要素数5の配列を初期化する
        //int[] points = new int[5];

        ////配列の各要素に値を代入する
        //points[0] = 30;
        //points[1] = 20;
        //points[2] = 50;
        //points[3] = 10;
        //points[4] = 80;

        ////配列の要素をすべて表示する
        //for(int i = 0; i < 5; i++)
        //{
        //    Debug.Log(points[i]);
        //}

        //int a = 3;
        //if (a == 3) {
        //    //変数aが3の場合、変数bを5で初期化する
        //    int b = 5;
        //    Debug.Log(b);
        //}



        //int num = 1;
        //int val = (num == 1) ? -100 : 100;
        //Debug.Log(val);



        ////moneyを100で初期化する
        //int money = 200;
        //
        //if (money <= 50) {
        //    //moneyが50以下だった場合の処理
        //    Debug.Log("武器を売る");
        //}else if(money >= 200) {
        //    //moneyが200以上だった場合の処理
        //    Debug.Log("武器を買う");
        //} else {
        //    Debug.Log("ポーションを買う");
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
