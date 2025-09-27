using OpenCvSharp;
using OpenCvSharp.Dnn;
using OpenCvSharp.ML;
using OpenVinoSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using YoloDeployPlatform.predictor;
using Size = OpenCvSharp.Size;

namespace YoloDeployPlatform
{
    public class Predictor :IDisposable
    {
        private Core core;
        private Model model;
        private CompiledModel compiled;
        private InferRequest openvino_infer;

        public Predictor() { }
        public Predictor(string model_path, string device) 
        {
            if (model_path == null) 
            {
                throw new ArgumentNullException(nameof(model_path));
            }
            core = new Core();
            model = core.read_model(model_path);
            compiled = core.compile_model(model, device);
            openvino_infer = compiled.create_infer_request();
          
        }

        public void Dispose()
        {

            openvino_infer.Dispose();
            compiled.Dispose();
            model.Dispose();
            core.Dispose();
    
            GC.Collect();

        }

        public List<float[]> infer(float[] input_data, List<string> input_names, int[] input_size, List<string> output_names, List<int[]> output_sizes) 
        {

            List<float[]> returns = new List<float[]>();
         
                    
            var input_tensor = openvino_infer.get_input_tensor();
            input_tensor.set_data(input_data);
            openvino_infer.infer();
            foreach (var name in output_names)
            {
                var output_tensor = openvino_infer.get_tensor(name);
                returns.Add(output_tensor.get_data<float>((int)output_tensor.get_size()));
            }
                        
    
            
            return returns;
        }
    }
}
