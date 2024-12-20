
using UnityEngine;

public class CriSoundExecuter : MonoBehaviour
{
    private void Start()
    {
        CRIAudioManager.Initialize(); //初期化
        CRIAudioManager.BGM.Play("BGM", "BGM"); //NOTE: 準備待ちがあるため遅延して再生されるが、指定する分には問題ない
    }

    private void Update()
    {
        //3Dサウンドの再生
        if (Input.GetKeyDown(KeyCode.Z))
        {
            CRIAudioManager.SE.Play3D(new Vector3(Random.Range(-100,100), 0, Random.Range(-100, 100)), "SE", "Attack");
        }

        //SEの再生
        if (Input.GetKeyDown(KeyCode.X))
        {
            CRIAudioManager.SE.Play("SE", "OK");
        }

        //SEの遅延再生
        if (Input.GetKeyDown(KeyCode.V))
        {
            CRIAudioManager.SE.Play("SE", "Attack", 1000.0f);
        }

        //BGM停止
        if (Input.GetKeyDown(KeyCode.S))
        {
            CRIAudioManager.BGM.Stop();
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            CRIAudioManager.SE.Play("ME", "FM");
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            CRIAudioManager.SE.Play("ME", "FM_Reverb");
        }
    }
}
