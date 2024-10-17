public class Neuron {
    public float Value;
    public List<Neuron> In, Out;
    public void ConnectTo(Neuron other){
        Out.Add(other);
        other.In.Add(this);
    }
}