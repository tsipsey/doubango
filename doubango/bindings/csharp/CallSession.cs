/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace org.doubango.tinyWRAP {

using System;
using System.Runtime.InteropServices;

public class CallSession : InviteSession {
  private HandleRef swigCPtr;

  internal CallSession(IntPtr cPtr, bool cMemoryOwn) : base(tinyWRAPPINVOKE.CallSession_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(CallSession obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~CallSession() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          tinyWRAPPINVOKE.delete_CallSession(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public CallSession(SipStack pStack) : this(tinyWRAPPINVOKE.new_CallSession(SipStack.getCPtr(pStack)), true) {
  }

  public bool callAudio(string remoteUriString, ActionConfig config) {
    bool ret = tinyWRAPPINVOKE.CallSession_callAudio__SWIG_0(swigCPtr, remoteUriString, ActionConfig.getCPtr(config));
    return ret;
  }

  public bool callAudio(string remoteUriString) {
    bool ret = tinyWRAPPINVOKE.CallSession_callAudio__SWIG_1(swigCPtr, remoteUriString);
    return ret;
  }

  public bool callAudio(SipUri remoteUri, ActionConfig config) {
    bool ret = tinyWRAPPINVOKE.CallSession_callAudio__SWIG_2(swigCPtr, SipUri.getCPtr(remoteUri), ActionConfig.getCPtr(config));
    return ret;
  }

  public bool callAudio(SipUri remoteUri) {
    bool ret = tinyWRAPPINVOKE.CallSession_callAudio__SWIG_3(swigCPtr, SipUri.getCPtr(remoteUri));
    return ret;
  }

  public bool callAudioVideo(string remoteUriString, ActionConfig config) {
    bool ret = tinyWRAPPINVOKE.CallSession_callAudioVideo__SWIG_0(swigCPtr, remoteUriString, ActionConfig.getCPtr(config));
    return ret;
  }

  public bool callAudioVideo(string remoteUriString) {
    bool ret = tinyWRAPPINVOKE.CallSession_callAudioVideo__SWIG_1(swigCPtr, remoteUriString);
    return ret;
  }

  public bool callAudioVideo(SipUri remoteUri, ActionConfig config) {
    bool ret = tinyWRAPPINVOKE.CallSession_callAudioVideo__SWIG_2(swigCPtr, SipUri.getCPtr(remoteUri), ActionConfig.getCPtr(config));
    return ret;
  }

  public bool callAudioVideo(SipUri remoteUri) {
    bool ret = tinyWRAPPINVOKE.CallSession_callAudioVideo__SWIG_3(swigCPtr, SipUri.getCPtr(remoteUri));
    return ret;
  }

  public bool callVideo(string remoteUriString, ActionConfig config) {
    bool ret = tinyWRAPPINVOKE.CallSession_callVideo__SWIG_0(swigCPtr, remoteUriString, ActionConfig.getCPtr(config));
    return ret;
  }

  public bool callVideo(string remoteUriString) {
    bool ret = tinyWRAPPINVOKE.CallSession_callVideo__SWIG_1(swigCPtr, remoteUriString);
    return ret;
  }

  public bool callVideo(SipUri remoteUri, ActionConfig config) {
    bool ret = tinyWRAPPINVOKE.CallSession_callVideo__SWIG_2(swigCPtr, SipUri.getCPtr(remoteUri), ActionConfig.getCPtr(config));
    return ret;
  }

  public bool callVideo(SipUri remoteUri) {
    bool ret = tinyWRAPPINVOKE.CallSession_callVideo__SWIG_3(swigCPtr, SipUri.getCPtr(remoteUri));
    return ret;
  }

  public bool setSessionTimer(uint timeout, string refresher) {
    bool ret = tinyWRAPPINVOKE.CallSession_setSessionTimer(swigCPtr, timeout, refresher);
    return ret;
  }

  public bool set100rel(bool enabled) {
    bool ret = tinyWRAPPINVOKE.CallSession_set100rel(swigCPtr, enabled);
    return ret;
  }

  public bool setICE(bool enabled) {
    bool ret = tinyWRAPPINVOKE.CallSession_setICE(swigCPtr, enabled);
    return ret;
  }

  public bool setQoS(tmedia_qos_stype_t type, tmedia_qos_strength_t strength) {
    bool ret = tinyWRAPPINVOKE.CallSession_setQoS(swigCPtr, (int)type, (int)strength);
    return ret;
  }

  public bool hold(ActionConfig config) {
    bool ret = tinyWRAPPINVOKE.CallSession_hold__SWIG_0(swigCPtr, ActionConfig.getCPtr(config));
    return ret;
  }

  public bool hold() {
    bool ret = tinyWRAPPINVOKE.CallSession_hold__SWIG_1(swigCPtr);
    return ret;
  }

  public bool resume(ActionConfig config) {
    bool ret = tinyWRAPPINVOKE.CallSession_resume__SWIG_0(swigCPtr, ActionConfig.getCPtr(config));
    return ret;
  }

  public bool resume() {
    bool ret = tinyWRAPPINVOKE.CallSession_resume__SWIG_1(swigCPtr);
    return ret;
  }

  public bool transfer(string referToUriString, ActionConfig config) {
    bool ret = tinyWRAPPINVOKE.CallSession_transfer__SWIG_0(swigCPtr, referToUriString, ActionConfig.getCPtr(config));
    return ret;
  }

  public bool transfer(string referToUriString) {
    bool ret = tinyWRAPPINVOKE.CallSession_transfer__SWIG_1(swigCPtr, referToUriString);
    return ret;
  }

  public bool acceptTransfer(ActionConfig config) {
    bool ret = tinyWRAPPINVOKE.CallSession_acceptTransfer__SWIG_0(swigCPtr, ActionConfig.getCPtr(config));
    return ret;
  }

  public bool acceptTransfer() {
    bool ret = tinyWRAPPINVOKE.CallSession_acceptTransfer__SWIG_1(swigCPtr);
    return ret;
  }

  public bool rejectTransfer(ActionConfig config) {
    bool ret = tinyWRAPPINVOKE.CallSession_rejectTransfer__SWIG_0(swigCPtr, ActionConfig.getCPtr(config));
    return ret;
  }

  public bool rejectTransfer() {
    bool ret = tinyWRAPPINVOKE.CallSession_rejectTransfer__SWIG_1(swigCPtr);
    return ret;
  }

  public bool sendDTMF(int number) {
    bool ret = tinyWRAPPINVOKE.CallSession_sendDTMF(swigCPtr, number);
    return ret;
  }

  public uint getSessionTransferId() {
    uint ret = tinyWRAPPINVOKE.CallSession_getSessionTransferId(swigCPtr);
    return ret;
  }

}

}
