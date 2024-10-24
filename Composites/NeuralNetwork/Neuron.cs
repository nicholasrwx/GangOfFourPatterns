// Neuron is a Scalar Value ( Individual Object ) that is being represented as an IEnumerable
// this allows it to be treated in a similar manner as a NeuronLayer which also Implements IEnumerable because it is a Collection
public class Neuron : IEnumerable<Neuron> {
    public float Value;
    public List<Neuron> In, Out;
    
    // This is now done in a similar manner within the Extension Method
    // public void ConnectTo(Neuron other){
    //    Out.Add(other);
    //    other.In.Add(this);
    // }

    public IEnumerator<Neuron> GetEnumerator()
    {
        // Returns the scalar value of Neuron, rather than the containing elements, which is providing an enumerator
        // This means a single neuron is masquerading as an enumeration by "yield returning" itself
        yield return this;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}