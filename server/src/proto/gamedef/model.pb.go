// Code generated by protoc-gen-go.
// source: model.proto
// DO NOT EDIT!

package gamedef

import proto "github.com/golang/protobuf/proto"
import fmt "fmt"
import math "math"

// Reference imports to suppress errors if they are not otherwise used.
var _ = proto.Marshal
var _ = fmt.Errorf
var _ = math.Inf

type LoginModel struct {
	Account string `protobuf:"bytes,1,opt,name=Account,json=account" json:"Account,omitempty"`
	Address string `protobuf:"bytes,2,opt,name=Address,json=address" json:"Address,omitempty"`
}

func (m *LoginModel) Reset()                    { *m = LoginModel{} }
func (m *LoginModel) String() string            { return proto.CompactTextString(m) }
func (*LoginModel) ProtoMessage()               {}
func (*LoginModel) Descriptor() ([]byte, []int) { return fileDescriptor3, []int{0} }

type ModelACK struct {
	Login      *LoginModel   `protobuf:"bytes,1,opt,name=Login,json=login" json:"Login,omitempty"`
	ServerList []*ServerInfo `protobuf:"bytes,2,rep,name=ServerList,json=serverList" json:"ServerList,omitempty"`
}

func (m *ModelACK) Reset()                    { *m = ModelACK{} }
func (m *ModelACK) String() string            { return proto.CompactTextString(m) }
func (*ModelACK) ProtoMessage()               {}
func (*ModelACK) Descriptor() ([]byte, []int) { return fileDescriptor3, []int{1} }

func (m *ModelACK) GetLogin() *LoginModel {
	if m != nil {
		return m.Login
	}
	return nil
}

func (m *ModelACK) GetServerList() []*ServerInfo {
	if m != nil {
		return m.ServerList
	}
	return nil
}

func init() {
	proto.RegisterType((*LoginModel)(nil), "gamedef.LoginModel")
	proto.RegisterType((*ModelACK)(nil), "gamedef.ModelACK")
}

func init() { proto.RegisterFile("model.proto", fileDescriptor3) }

var fileDescriptor3 = []byte{
	// 166 bytes of a gzipped FileDescriptorProto
	0x1f, 0x8b, 0x08, 0x00, 0x00, 0x09, 0x6e, 0x88, 0x02, 0xff, 0xe2, 0xe2, 0xce, 0xcd, 0x4f, 0x49,
	0xcd, 0xd1, 0x2b, 0x28, 0xca, 0x2f, 0xc9, 0x17, 0x62, 0x4f, 0x4f, 0xcc, 0x4d, 0x4d, 0x49, 0x4d,
	0x93, 0xe2, 0xce, 0xc9, 0x4f, 0xcf, 0xcc, 0x83, 0x88, 0x2a, 0x39, 0x70, 0x71, 0xf9, 0x80, 0xb8,
	0xbe, 0x20, 0x95, 0x42, 0x12, 0x5c, 0xec, 0x8e, 0xc9, 0xc9, 0xf9, 0xa5, 0x79, 0x25, 0x12, 0x8c,
	0x0a, 0x8c, 0x1a, 0x9c, 0x41, 0xec, 0x89, 0x10, 0x2e, 0x58, 0x26, 0x25, 0xa5, 0x28, 0xb5, 0xb8,
	0x58, 0x82, 0x09, 0x2a, 0x03, 0xe1, 0x2a, 0x65, 0x71, 0x71, 0x80, 0x35, 0x3b, 0x3a, 0x7b, 0x0b,
	0x69, 0x72, 0xb1, 0x82, 0x4d, 0x03, 0xeb, 0xe6, 0x36, 0x12, 0xd6, 0x83, 0xda, 0xa9, 0x87, 0xb0,
	0x23, 0x88, 0x15, 0x6c, 0xbd, 0x90, 0x31, 0x17, 0x57, 0x70, 0x6a, 0x51, 0x59, 0x6a, 0x91, 0x4f,
	0x66, 0x71, 0x09, 0xd0, 0x4c, 0x66, 0x14, 0xf5, 0x10, 0x29, 0xcf, 0xbc, 0xb4, 0xfc, 0x20, 0xae,
	0x62, 0xb8, 0xb2, 0x24, 0x36, 0xb0, 0xa3, 0x8d, 0x01, 0x01, 0x00, 0x00, 0xff, 0xff, 0xa0, 0x56,
	0xe3, 0xdb, 0xd9, 0x00, 0x00, 0x00,
}
