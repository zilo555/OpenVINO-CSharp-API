using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static OpenVinoSharp.NativeMethods;

namespace OpenVinoSharp
{

    /// <summary>
    /// 日志记录器类，用于接收和处理来自本地库的日志消息
    /// Logger class for receiving and handling log messages from native libraries
    /// </summary>
    public class Logger : IDisposable
    {
        // 日志回调委托，用于与本地代码进行互操作
        // Log callback delegate for interoperability with native code
        private readonly LogCallbackDelegate _callback;

        // 标记对象是否已被释放，防止重复释放
        // Flag indicating whether the object has been disposed, preventing double disposal
        private bool _isDisposed = false;

        /// <summary>
        /// 构造函数：初始化日志记录器并设置本地日志回调
        /// Constructor: Initializes the logger and sets up the native log callback
        /// </summary>
        public Logger()
        {
            // 创建回调委托，将本地日志消息转发到C#事件
            // Create callback delegate to forward native log messages to C# events
            _callback = (message) =>
            {
                // 可以在这里添加更复杂的日志逻辑，例如：
                // - 格式化消息
                // - 写入文件
                // - 发送到网络
                // Additional logging logic can be added here, such as:
                // - Message formatting
                // - File writing
                // - Network transmission

                // 调用事件触发方法，通知所有订阅者
                // Call event trigger method to notify all subscribers
                OnLogReceived(message);
            };

            // 设置本地库的日志回调函数
            // Set the log callback function for the native library
            // 假设 ov_util_set_log_callback 是通过P/Invoke导入的本地函数
            // Assumption: ov_util_set_log_callback is a native function imported via P/Invoke
            ov_util_set_log_callback(_callback);
        }


        /// <summary>
        /// 日志消息接收事件，当本地库产生日志时触发
        /// Event that fires when log messages are received from the native library
        /// </summary>
        public event Action<string> LogReceived;

        /// <summary>
        /// 触发日志接收事件
        /// Raises the log received event
        /// </summary>
        /// <param name="message">日志消息 / Log message</param>
        protected virtual void OnLogReceived(string message)
        {
            // 使用空合并运算符安全地调用事件订阅者
            // Safely invoke event subscribers using null-conditional operator
            LogReceived?.Invoke(message);
        }

        /// <summary>
        /// 重置日志回调，清除本地库的日志设置
        /// Resets the log callback, clearing the native library's log settings
        /// </summary>
        public void Reset()
        {
            // 检查是否已被释放，避免操作已释放的资源
            // Check if disposed to avoid operating on released resources
            if (!_isDisposed)
            {
                // 调用本地函数重置日志回调
                // Call native function to reset log callback
                // 假设 ov_util_reset_log_callback 是通过P/Invoke导入的本地函数
                // Assumption: ov_util_reset_log_callback is a native function imported via P/Invoke
                ov_util_reset_log_callback();

                // 标记为已释放
                // Mark as disposed
                _isDisposed = true;
            }
        }

        /// <summary>
        /// 实现IDisposable接口，执行资源清理
        /// Implements IDisposable interface for resource cleanup
        /// </summary>
        public void Dispose()
        {
            // 执行释放逻辑
            // Execute disposal logic
            Reset();

            // 通知垃圾回收器不需要再调用析构函数
            // Tell garbage collector not to call finalizer
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// 析构函数，作为安全网确保资源被释放
        /// Finalizer, acts as a safety net to ensure resources are released
        /// </summary>
        ~Logger()
        {
            // 在对象被垃圾回收时释放资源
            // Release resources when object is garbage collected
            Dispose();
        }

        // 以下声明假设通过P/Invoke从本地库导入的函数
        // The following declarations assume native functions imported via P/Invoke

        // [DllImport("your_native_library.dll")]
        // private static extern void ov_util_set_log_callback(LogCallbackDelegate callback);

        // [DllImport("your_native_library.dll")]
        // private static extern void ov_util_reset_log_callback();
    }



}
