using UnityEngine.Audio;
using UnityEngine;


[System.Serializable]
public class sound
{
    public AudioClip clip;
    public string name;

    [Range(0f,3f)]public float volume;
    [Range(.1f, 3f)] public float pitch;
    public bool loop;

    public AudioSource source;
}
